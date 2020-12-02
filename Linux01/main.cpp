#include <cstdio>
#include <malloc.h>
#include <sys/stat.h>
#include <elf.h>
#include "kv32.h"

unsigned long readFile(const char *fileName, unsigned char **fileBuff);

void each_Elf32_Phdr(Elf32_Phdr *headers, int num);
void each_Elf32_Shdr(Elf32_Shdr *headers, int num);
void print_Elf32_Ehdr(Elf32_Ehdr *header);
void print_Elf32_Phdr(Elf32_Phdr *header);
void print_Elf32_Shdr(Elf32_Shdr *header);

struct {
    /* 文件头 */
    Elf32_Ehdr* Ehdr;
    /* 程序头表 */
    Elf32_Phdr* Phdrs;
    /* 节头表 */
    Elf32_Shdr* Shdrs;
    /* 节头名所在字符串表位置 */
    unsigned char* shstrtab_offset;
} elf32 ;

V* gvp = NULL;
int main(int argc,char** args)
{
    unsigned char *filebuf = NULL;
    const char * const fileName = "/home/td/projects/1";
    unsigned long ret = readFile(fileName, &filebuf);
    printf("\r\n文件位置: %s\r\n", fileName);
    printf("文件大小: %lld\r\n\r\n",ret);
    if (ret == 0)
    {
        perror("文件不存在");
        return 0;
    }

    elf32.Ehdr = (Elf32_Ehdr*)filebuf;
    elf32.Phdrs = (Elf32_Phdr*)(filebuf + elf32.Ehdr->e_phoff);
    elf32.Shdrs = (Elf32_Shdr*)(filebuf + elf32.Ehdr->e_shoff);
    elf32.shstrtab_offset = filebuf + ((elf32.Shdrs + elf32.Ehdr->e_shstrndx)->sh_offset);
    
    print_Elf32_Ehdr(elf32.Ehdr);
    each_Elf32_Phdr(elf32.Phdrs, elf32.Ehdr->e_phnum);
    each_Elf32_Shdr(elf32.Shdrs, elf32.Ehdr->e_shnum);
    

    return 0;
}

void each_Elf32_Shdr(Elf32_Shdr *headers,int num) {
    printf("\r\n========================================== Elf32 节头表 (表项数量: %d) ==========================================\r\n", num);
    /* 节索引为0时，为未指定的节，其它特定索引，详见: elf.h 414 */
    for (int i = 0; i < num; i++) {
        print_Elf32_Shdr(headers + i);
        printf("\r\n");
    }
}

void each_Elf32_Phdr(Elf32_Phdr *headers,int num)
{
    printf("\r\n========================================== Elf32 程序头表 (表项数量: %d) ==========================================\r\n", num);
    for (int i = 0; i < num; i++)
    {
        print_Elf32_Phdr(headers + i);
        printf("\r\n");
    }
}

void print_Elf32_Ehdr(Elf32_Ehdr *header)
{
    printf("============================================= Elf32 文件头 (大小: %d) =============================================\r\n", sizeof(*header));
    printf("                 魔数及其它信息 (Magic number and other info): ");
    for (int i = 0; i < 16; i++) { printf("%2.2X ", *(header->e_ident + i)); }
    puts("");
    unsigned char m4[5] = { header->e_ident[0],header->e_ident[1] ,header->e_ident[2] ,header->e_ident[3],0 };
    printf("                                       \b魔数标识 (Magic)[0,3]: %s\r\n", m4);                                                  // 魔数标识，固定\177ELF
    findV(Elf32_Ehdr_Magic_Class, sizeof(Elf32_Ehdr_Magic_Class), header->e_ident[4], &gvp);
    printf("                                         \b32或64 (Class)[  4]: 0x%X %s (%s)\r\n", gvp->value, gvp->name, gvp->description);   // 0无效 1 32位 2 63位
    findV(Elf32_Ehdr_Magic_Data, sizeof(Elf32_Ehdr_Magic_Data), header->e_ident[5], &gvp);
    printf("                                          \b大小端 (Data)[  5]: 0x%X %s (%s)\r\n", gvp->value, gvp->name, gvp->description);   // 数据编码 0无效 1 小端 2 大端
    printf("                                     \b文件版本 (Version)[  6]: %d\r\n", header->e_ident[6]);                                  // 必须和e_version对应
    findV(Elf32_Ehdr_Magic_OSABI, sizeof(Elf32_Ehdr_Magic_OSABI), header->e_ident[7], &gvp);
    printf("                                       \b系统ABI (OS/ABI)[  7]: 0x%X %s\r\n", gvp->value, gvp->name);                          // 系统ABI
    printf("                                  \bABI版本 (ABI Version)[  8]: %d\r\n", header->e_ident[8]);                                  // ABI版本
    printf("                                        \b填充 (Padding)[9,15]: %d %d %d %d %d %d\r\n\r\n", 0, 0, 0, 0, 0, 0);                 // 6位填充位
    findV(Elf32_Ehdr_e_type, sizeof(Elf32_Ehdr_e_type), header->e_type, &gvp);                                                             // 对象文件类型
    printf("                     对象文件类型 (Object file type)[大小: %d]: 0x%X %s (%s)\r\n", sizeof(header->e_type), gvp->value, gvp->name, gvp->description);
    findV(Elf32_Ehdr_e_machine, sizeof(Elf32_Ehdr_e_machine), header->e_machine, &gvp);                                                    // 机型
    printf("                                  系统架构 (Machine)[大小: %d]: 0x%X %s\r\n", sizeof(header->e_machine), gvp->value, gvp->name);
    findV(Elf32_Ehdr_e_version, sizeof(Elf32_Ehdr_e_version), header->e_version, &gvp);                                                    // 对象文件版本
    printf("                              对象文件版本 (Version)[大小: %d]: 0x%X %s (%s)\r\n", sizeof(header->e_version), gvp->value, gvp->name, gvp->description);
    printf("              程序入口虚拟地址 (Entry point address)[大小: %d]: 0x%X\r\n", sizeof(header->e_entry), header->e_entry);          // 程序入口虚拟地址
    printf("             程序头表偏移 (Start of program headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_phoff), header->e_phoff);          // 程序头表偏移
    printf("               节头表偏移 (Start of section headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_shoff), header->e_shoff);          // 节头表偏移
    printf("         处理器指定标志位 (Processor-specific flags)[大小: %d]: 0x%X\r\n", sizeof(header->e_flags), header->e_flags);          // 处理器指定标志位
    printf("                     ELF头大小 (Size of this header)[大小: %d]: 0x%X\r\n", sizeof(header->e_ehsize), header->e_ehsize);        // ELF头大小, 32位固定32 64位固定64
    printf("            程序头条目大小 (Size of program headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_phentsize), header->e_phentsize);  // 程序头表内每个条目(结构体)的大小
    printf("          程序头条目数量 (Number of program headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_phnum), header->e_phnum);          // 程序头表内条目(结构体)的数量，或者说程序头表内有多少张表(或条目，或结构体)
    printf("            节头表条目大小 (Size of section headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_shentsize), header->e_shentsize);  // 节头表内每个条目(结构体)的大小
    printf("          节头标条目数量 (Number of section headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_shnum), header->e_shnum);          // 节头表内每个条目(结构体)的数量,或者说节头表内有多少张表(或条目，或结构体)
    printf("字符串表节头索引 (Section header string table index)[大小: %d]: 0x%X\r\n", sizeof(header->e_shstrndx), header->e_shstrndx);    // 字符串表在节头表中的索引
}

void print_Elf32_Phdr(Elf32_Phdr *header) {
    findV(Elf32_Phdr_p_type, sizeof(Elf32_Phdr_p_type), header->p_type, &gvp);
    printf("                                         段类型 (Segment type): 0x%X %s (%s)\r\n",header->p_type,gvp->name,gvp->description);
    printf("                            文件内段偏移 (Segment file offset): 0x%X\r\n", header->p_offset);
    printf("                          段虚拟地址 (Segment virtual address): 0x%X\r\n", header->p_vaddr);
    printf("                         段物理地址 (Segment physical address): 0x%X\r\n", header->p_paddr);
    printf("                           文件内段大小 (Segment size in file): 0x%X\r\n", header->p_filesz);
    printf("                         内存内段大小 (Segment size in memory): 0x%X\r\n", header->p_memsz);
    printf("                             段标识符 (Segment flags)(RWX,421): 0x%X\r\n", header->p_flags);
    printf("                                段对齐方式 (Segment alignment): 0x%X\r\n", header->p_align);
}

void print_Elf32_Shdr(Elf32_Shdr *header) {
    printf("                                           节名 (Section name): %s\r\n",elf32.shstrtab_offset + header->sh_name);
    findV(Elf32_Shdr_sh_type, sizeof(Elf32_Shdr_sh_type), header->sh_type, &gvp);
    printf("                                         节类型 (Section type): 0x%X %s (%s)\r\n",header->sh_type, gvp->name, gvp->description);
    findV(Elf32_Shdr_sh_flags, sizeof(Elf32_Shdr_sh_flags), header->sh_flags, &gvp);
    printf("                                        节标志 (Section flags): 0x%X %s (%s)\r\n",header->sh_flags, gvp->name, gvp->description);
    printf("虚拟空间(执行时)内虚拟地址 (Section virtual addr at execution): 0x%X\r\n",header->sh_addr);
    printf("                              文件内偏移 (Section file offset): 0x%X\r\n",header->sh_offset);
    printf("                                节大小 (Section size in bytes): 0x%X\r\n",header->sh_size);
    printf("                            节内索引 (Link to another section): 0x%X\r\n",header->sh_link);
    printf("                     附加信息 (Additional section information): 0x%X\r\n",header->sh_info);
    printf("                                节对齐方式 (Section alignment): 0x%X\r\n",header->sh_addralign);
    printf("              节内表项大小 (Entry size if section holds table): 0x%X\r\n",header->sh_entsize);
}



unsigned long readFile(const char *fileName,unsigned char **fileBuff)
{
    struct stat s;
    int ret = stat(fileName, &s);
    if (ret != 0)
    {
        return 0;
    }
    *fileBuff = (unsigned char*)malloc(s.st_size);
    if (*fileBuff == NULL)
    {
        return 0;
    }
    FILE *file;
    file = fopen(fileName, "rb");
    if (file == NULL)
    {
        return 0;
    }
    fread(*fileBuff, 1, s.st_size, file);
    fclose(file);
    return s.st_size;
}

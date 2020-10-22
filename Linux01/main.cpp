#include <cstdio>
#include <unistd.h>
#include <cstring>
#include <malloc.h>
#include <sys/stat.h>
#include <elf.h>

unsigned long readFile(const char *fileName, unsigned char **fileBuff);
void swap(int* a, int* b);
void printHeader32(Elf32_Ehdr* header);
void printCharArray(unsigned char* arr, int lenght);

int main(int argc,char** args)
{
    unsigned char *file = NULL;
    const char * const fileName = "/home/td/projects/1";
    unsigned long ret = readFile(fileName, &file);
    printf("\r\n文件位置: %s\r\n", fileName);
    printf("文件大小: %lld\r\n\r\n",ret);
    Elf32_Ehdr Header32;
    memcpy(&Header32, file, sizeof(Elf32_Ehdr));
    printHeader32(&Header32);
    return 0;
}

void printHeader32(Elf32_Ehdr *header)
{
    printf("============================================= Elf32 文件头 (大小: %d) =============================================\r\n", sizeof(*header));
    printf("                 魔数及其它信息 (Magic number and other info): ");
    for (int i = 0; i < 16; i++){printf("%2.2X ", *(header->e_ident + i));}
    puts("");
    unsigned char m4[5] = {header->e_ident[0],header->e_ident[1] ,header->e_ident[2] ,header->e_ident[3],0 };
    printf("                                       \b魔数标识 (Magic)[0,3]: %s\r\n", m4);                                                  // 魔数标识，固定\177ELF
    printf("                                         \b32或64 (Class)[  4]: %d\r\n", header->e_ident[4]);                                  // 0无效 1 32位 2 63位
    printf("                                          \b大小端 (Data)[  5]: %d\r\n", header->e_ident[5]);                                  // 数据编码 0无效 1 小端 2 大端
    printf("                                     \b文件版本 (Version)[  6]: %d\r\n", header->e_ident[6]);                                  // e_version对应
    printf("                                       \b系统ABI (OS/ABI)[  7]: %d\r\n", header->e_ident[7]);                                  // 系统ABI
    printf("                                  \bABI版本 (ABI Version)[  8]: %d\r\n", header->e_ident[8]);                                  // ABI版本
    printf("                                        \b填充 (Padding)[9,15]: %d %d %d %d %d %d\r\n\r\n",0, 0, 0, 0, 0, 0);                  // 6位填充位
    printf("                                 对象文件类型 (Type)[大小: %d]: 0x%X\r\n", sizeof(header->e_type),header->e_type);             // 文件类型 elf.h 162 行
    printf("                                  构建类型 (Machine)[大小: %d]: 0x%X\r\n", sizeof(header->e_machine),header->e_machine);       // 构建类型 elf.h 175 行
    printf("                              对象文件版本 (Version)[大小: %d]: 0x%X\r\n", sizeof(header->e_version),header->e_version);       // 文件版本 elf.h 378 行
    printf("              程序入口虚拟地址 (Entry point address)[大小: %d]: 0x%X\r\n", sizeof(header->e_entry),header->e_entry);           // 程序入口虚拟地址
    printf("             程序头表偏移 (Start of program headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_phoff),header->e_phoff);           // 程序头表偏移
    printf("               节头表偏移 (Start of section headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_shoff),header->e_shoff);           // 节头表偏移
    printf("                                      标志位 (Flags)[大小: %d]: 0x%X\r\n", sizeof(header->e_flags),header->e_flags);           // 平台相关标志位，现在还看不懂
    printf("                     ELF头大小 (Size of this header)[大小: %d]: 0x%X\r\n", sizeof(header->e_ehsize),header->e_ehsize);         // ELF头大小, 32位固定32 64位固定64
    printf("            程序头条目大小 (Size of program headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_phentsize), header->e_phentsize);  // 程序头表内每个条目(结构体)的大小
    printf("          程序头条目数量 (Number of program headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_phnum), header->e_phnum);          // 程序头表内条目(结构体)的数量，或者说程序头表内有多少张表(或条目，或结构体)
    printf("            节头表条目大小 (Size of section headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_shentsize),header->e_shentsize);   // 节头表内每个条目(结构体)的大小
    printf("          节头标条目数量 (Number of section headers)[大小: %d]: 0x%X\r\n", sizeof(header->e_shnum),header->e_shnum);           // 节头表内每个条目(结构体)的数量,或者说节头表内有多少张表(或条目，或结构体)
    printf("字符串表节头索引 (Section header string table index)[大小: %d]: 0x%X\r\n", sizeof(header->e_shstrndx), header->e_shstrndx);    // 字符串表在节头表中的索引
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

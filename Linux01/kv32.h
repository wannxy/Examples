#ifndef _KV32_H
#define _KV32_H
#include <elf.h>

typedef struct V{
	const unsigned int value;
	const char* name;
	const char* description;
};

extern struct V Elf32_Ehdr_Magic_Class[4];   //字节集类型
extern struct V Elf32_Ehdr_Magic_Data[4];    //数据编码，大小端
extern struct V Elf32_Ehdr_Magic_OSABI[16];  //OSABI
extern struct V Elf32_Ehdr_e_type[10];       //对象文件类型
extern struct V Elf32_Ehdr_e_machine[179];   //机型
extern struct V Elf32_Ehdr_e_version[3];     //文件版本

extern struct V Elf32_Phdr_p_type[20];       //程序头类型

extern struct V Elf32_Shdr_sh_type[36];      //节头表类型
extern struct V Elf32_Shdr_sh_flags[15];     //节头表标识

int findV(V* vs, int size, int index, V** v);
#endif
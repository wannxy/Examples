#ifndef _KV32_H
#define _KV32_H
#include <elf.h>

typedef struct V{
	const unsigned int value;
	const char* name;
	const char* description;
};

extern struct V Elf32_Ehdr_Magic_Class[4];   //�ֽڼ�����
extern struct V Elf32_Ehdr_Magic_Data[4];    //���ݱ��룬��С��
extern struct V Elf32_Ehdr_Magic_OSABI[16];  //OSABI
extern struct V Elf32_Ehdr_e_type[10];       //�����ļ�����
extern struct V Elf32_Ehdr_e_machine[179];   //����
extern struct V Elf32_Ehdr_e_version[3];     //�ļ��汾

extern struct V Elf32_Phdr_p_type[20];       //����ͷ����

extern struct V Elf32_Shdr_sh_type[36];      //��ͷ������
extern struct V Elf32_Shdr_sh_flags[15];     //��ͷ���ʶ

int findV(V* vs, int size, int index, V** v);
#endif
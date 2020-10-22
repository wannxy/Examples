#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <io.h>
#include <sys/stat.h>
#include <sys/types.h>

int main(int argc, char** args)
{
	char* const filename = "C:/Users/F1/Desktop/Transfer/1";
	struct _stat buf;
	int result;
	result = _stat(filename, &buf);
	unsigned char* p;
	p = &buf;
	
	printf("%d\r\n",*(p+13));
	return 0;
}

int f1()
{
	FILE* fp = NULL;
	fp = fopen("C:/Users/F1/Desktop/Transfer/1", "rb");
	if (fp == 0)
	{
		perror("Error");
		return -1;
	}
	int fno = _fileno(fp);
	int fsize = _filelength(fno);
	unsigned char* fBuff = NULL;
	unsigned char buff[1024];
	fBuff = malloc(fsize);
	if (fBuff == NULL)
	{
		perror("Error");
		return;
	}
	memset(fBuff, 0, fsize);
	int total = 0;
	while (!feof(fp))
	{
		size_t size = fread(buff, 1, sizeof(buff), fp);
		memcpy(fBuff + total, buff, size);
		total += size;
	}
	fclose(fp);
	for (size_t i = 0; i < fsize; i++)
	{
		printf("%.2X ", *(fBuff + i));
	}
}
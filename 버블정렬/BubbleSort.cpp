/*
*��������(Bubble Sort) : ������ �� ���� ���Ҹ� ���Ͽ� �ڸ��� ��ȯ�ϴ� ���

ù ��° ���Һ��� ������ ���ұ��� �ݺ��ϸ� ���� ū ���Ұ� ������ �ڸ��� �´�.
ù ��° ���Һ��� ������ ���ҳ��� ��� �ڸ��� ��ȯ�ϸ鼭 �� ������ �ڸ��� �̵��ϴ� �����
�� �ӿ��� �� ���� �ö���� ����� ���� ���ٰ� �ؼ� ���������̶�� Ī��
*/

#include <stdio.h>
#include <stdlib.h>

void bubbleSort(int list[], int Size); // �������� �Լ� ����

void bubbleSort(int list[], int Size)  // �������� �Լ�
{
	int i, j, sort, temp;

	for (sort = 0; sort < Size; sort++) {   // list�迭 ���� �����ϰ��� �ϴ� ���ҵ� ���
		printf("%3d", list[sort]);
	}
	printf("\n\n<<<<<<<<<<<<< �������� ���� >>>>>>>>>>>>>>>\n");

	for (i = Size - 1; i >0; i--) {
		printf("\n%d �ܰ� : ",Size-i);
		for (j = -1; j<i; j++) {            //  ù��° ���Һ��� i�� ���ұ��� �ݺ�����                   for (j = 0; j<=i; j++) �� ��Ÿ�� �� �ִ� 

			if (list[j] > list[j+1]) {      // ������ �� ���� ���Ҹ� ���Ͽ� �ڸ��� ��ȯ                  if (list[j-1] > list[j]) {
				  
				temp = list[j];             //                                                              temp = list[j-1];
				list[j] = list[j+1];        //                                                              list[j-1] = list[j]; 
				list[j+1] = temp;           //                                                              list[j] = temp;
				 
			}                               //                                                               }
			printf("\n\t");
			for (sort = 0; sort <Size; sort++) printf("%3d ", list[sort]); // ������ �� �ܰ躰�� ��� ���
		}

	}
}

void main() {


	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };  // �����ϰ��� �ϴ� ���Ҹ���Ʈ List
	int Size = sizeof(List) / sizeof(List[0]);        // ��ü �迭�� ũ�⸦ ������ ũ��� ������ �迭�� ũ�⸦ �� �� �ִ�.

	printf("**�������� (Bubble Sort)\n");           // �������Ŀ� ���Ͽ�
	printf("������ �� ���� ���Ҹ� ���Ͽ� �ڸ��� ��ȯ�ϴ� ������� �����ϴ� ��� \n\n");

	bubbleSort(List, Size);                      //�������� �Լ� ȣ��
	getchar();

	system("pause");

}
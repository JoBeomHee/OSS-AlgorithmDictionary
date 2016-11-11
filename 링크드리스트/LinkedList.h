#pragma once
/*���� �迭ó�� ���Ḯ��Ʈ�� �������� ������ ��ü�� ���Ŀ� ������� ������
�� �ְ� �����մϴ�.. ����ϱ� ���ϰ� void * ������ Element �������� Ÿ�� �������մϴ�.*/
typedef int Element;

/* ���Ḯ��Ʈ�� ����� ���� �����Դϴ�. ���� ��ũ�� �������� ��������
���⿡���� �� ���� ��ũ�� ���� ��带 ������ ���Դϴ�.*/
typedef struct _Node Node;
typedef Node *Link;
struct _Node
{
	Link next;
	Link prev;
	Element data;
};

/*���Ḯ��Ʈ ����ü���� �� �տ� �ִ� ���� ����� ��ġ ������ head��
�� �ڿ� �ִ� ���� ����� ��ġ ������ tail�� ������ �ڷ� ������ ����� �����մϴ�.*/
typedef struct _LinkedList LinkedList;
struct _LinkedList
{
	Link head;
	Link tail;
	int usage;
};

LinkedList *New_LinkedList(); //���Ḯ��Ʈ ��������
void Delete_LinkedList(LinkedList *linkedlist); //���Ḯ��Ʈ ����
void LinkedList_PushBack(LinkedList *linkedlist, Element data); //���Ḯ��Ʈ ������ ����
void LinkedList_Insert(LinkedList *linkedlist, Link pos, Element data); //���ϴ� ���տ� ����
Link LinkedList_Begin(LinkedList *linkedlist); //�� �տ� �ִ� ��� �ڷ� ��ġ
Link LinkedList_End(LinkedList *linkedlist); //�� �ڿ� �ִ� ��� �ڷ� ��ġ
void LinkedList_Erase(LinkedList *linkedlist, Link pos); //Ư�� ��ġ�� ��� ����
#include "LinkedList.h"
#include <malloc.h>
Link New_Node(Element data) //��带 �����ϴ� �Լ�
{
	//���� Node ���� ũ���� �޸𸮸� �Ҵ��մϴ�.
	Link link = (Link)malloc(sizeof(Node));
	link->data = data;
	link->next = 0;
	link->prev = 0;

	//�ʱ� ��ũ���� �Ϸ� �� ��ȯ
	return link;
}

LinkedList *New_LinkedList() //���Ḯ��Ʈ ��������
{
	LinkedList *linkedlist = 0;
	//LinkedList �������� �޸𸮸� �Ҵ��Ѵ�.
	linkedlist = (LinkedList*)malloc(sizeof(LinkedList));

	//head�� tail�� ���̳��� �������ش�.
	linkedlist->head = New_Node(0);
	linkedlist->tail = New_Node(0);

	//head�� next��ũ�� tail�� ����Ű�� �ϰ� tail�� prev ��ũ�� head�� ����Ű�� �մϴ�.
	linkedlist->head->next = linkedlist->tail;
	linkedlist->tail->prev = linkedlist->head;

	//����� 0���� �ʱ�ȭ
	linkedlist->usage = 0;

	return linkedlist;
}

void Delete_LinkedList(LinkedList *linkedlist) //���Ḯ��Ʈ ����ȭ
{
	/*���Ḯ��Ʈ�� ����ȭ�ϴ� �Լ������� head���� ��ũ�� ���󰡸鼭
	tail�� ����Ű�� ��带 ������ �Ŀ� �ڽ��� �����ؾ� �մϴ�.*/
	Link seek = linkedlist->head;
	while (seek != linkedlist->tail)
	{
		seek = seek->next;
		free(seek);
	}
	/*���� �ݺ��������� ������ ���� �������� ���� �����Դϴ�.
	���� tail�� ����Ű�� ��带 ������ �Ŀ� �ڽ��� �޸𸮸� �����մϴ�.*/
	free(linkedlist->tail);
	free(linkedlist);
}

void LinkedList_PushBack(LinkedList *linkedlist, Element data) //���Ḯ��Ʈ ������ ����
{
	//tail �տ� �ڷḦ �����ϸ� ���������� ������ �� �ֽ��ϴ�.
	LinkedList_Insert(linkedlist, linkedlist->tail, data);
}

void HangNode(Link now, Link pos)
{
	//�� ���ο� now�� prev�� pos�� prev�� �����մϴ�. �׸��� now�� next�� pos�� �����մϴ�.
	now->prev = pos->prev;
	now->next = pos;

	// �׸��� pos�� prev ����� next�� now�� �����մϴ�.
	pos->prev->next = now;
	//���������� pos�� prev�� now�� �����մϴ�.
	pos->prev = now;
}

void LinkedList_Insert(LinkedList *linkedlist, Link pos, Element data) //���ϴ� ���տ� ����
{
	//�ڷḦ �����ϴ� ��� ����
	Link link = New_Node(data);

	//�׸��� �Է� ���ڷ� ���� ��� �տ� ���� ������ ��带 �����մϴ�.�� �κ��� ������ �Լ��� �ۼ��մϴ�.
	HangNode(link, pos);
	//������ �ڷ��� ������ 1 �����մϴ�.
	linkedlist->usage++;
}

Link LinkedList_Begin(LinkedList *linkedlist) //�� �տ� �ִ� ��� �ڷ� ��ġ
{
	//���Ḯ��Ʈ�� head�� ����Ű�� ���� ���� ����̸� head�� next�� ����Ű�� ��尡 �ڷḦ ������ �� ���� ����Դϴ�.
	return linkedlist->head->next;
}

Link LinkedList_End(LinkedList *linkedlist) //�� �ڿ� �ִ� ��� �ڷ� ��ġ
{
	//������ �� ������ ������ �ڷḦ ������ ����� ���� ��尡 tail�Դϴ�.
	return linkedlist->tail;
}


void DisconnectNode(Link pos)
{
	//������ ���� ����� ����(prev) ����� next�� ������ ���� ����� ����(next) ���� �����մϴ�.
	pos->prev->next = pos->next;
	//������ ���� ����� ����(next) ����� prev�� ������ ���� ����� ����(prev) ���� �����մϴ�.
	pos->next->prev = pos->prev;
}

void LinkedList_Erase(LinkedList *linkedlist, Link pos) //Ư�� ��ġ�� ��� ����
{
	//���� ������ �����ϴ�. �� �κ��� ������ �Լ��� �ۼ��սô�.
	DisconnectNode(pos);
	//�׸��� ��带 ���� �Ҵ��� �޸𸮸� �����ϰ� ������ �ڷ� ������ 1 �����մϴ�.
	free(pos);
	linkedlist->usage--;
}


#include "LinkedList.h"
#include <malloc.h>
Link New_Node(Element data) //노드를 생성하는 함수
{
	//먼저 Node 형식 크기의 메모리를 할당합니다.
	Link link = (Link)malloc(sizeof(Node));
	link->data = data;
	link->next = 0;
	link->prev = 0;

	//초기 링크설정 완료 후 반환
	return link;
}

LinkedList *New_LinkedList() //연결리스트 동적생성
{
	LinkedList *linkedlist = 0;
	//LinkedList 동적으로 메모리를 할당한다.
	linkedlist = (LinkedList*)malloc(sizeof(LinkedList));

	//head와 tail을 더미노드로 생성해준다.
	linkedlist->head = New_Node(0);
	linkedlist->tail = New_Node(0);

	//head의 next링크를 tail을 가리키게 하고 tail의 prev 링크를 head를 가르키게 합니다.
	linkedlist->head->next = linkedlist->tail;
	linkedlist->tail->prev = linkedlist->head;

	//저장소 0으로 초기화
	linkedlist->usage = 0;

	return linkedlist;
}

void Delete_LinkedList(LinkedList *linkedlist) //연결리스트 해제화
{
	/*연결리스트를 해제화하는 함수에서는 head에서 링크를 따라가면서
	tail이 가리키는 노드를 해제한 후에 자신을 해제해야 합니다.*/
	Link seek = linkedlist->head;
	while (seek != linkedlist->tail)
	{
		seek = seek->next;
		free(seek);
	}
	/*위의 반복문에서는 마지막 노드는 제거하지 않은 상태입니다.
	따라서 tail이 가르키는 노드를 제거한 후에 자신의 메모리를 해제합니다.*/
	free(linkedlist->tail);
	free(linkedlist);
}

void LinkedList_PushBack(LinkedList *linkedlist, Element data) //연결리스트 순차적 보관
{
	//tail 앞에 자료를 보관하면 순차적으로 보관할 수 있습니다.
	LinkedList_Insert(linkedlist, linkedlist->tail, data);
}

void HangNode(Link now, Link pos)
{
	//저 새로운 now의 prev를 pos의 prev로 설정합니다. 그리고 now의 next를 pos로 설정합니다.
	now->prev = pos->prev;
	now->next = pos;

	// 그리고 pos의 prev 노드의 next를 now로 설정합니다.
	pos->prev->next = now;
	//마지막으로 pos의 prev를 now로 설정합니다.
	pos->prev = now;
}

void LinkedList_Insert(LinkedList *linkedlist, Link pos, Element data) //원하는 노드앞에 삽입
{
	//자료를 보관하는 노드 생성
	Link link = New_Node(data);

	//그리고 입력 인자로 받은 노드 앞에 새로 생성한 노드를 연결합니다.이 부분은 별도의 함수로 작성합니다.
	HangNode(link, pos);
	//보관한 자료의 개수를 1 증가합니다.
	linkedlist->usage++;
}

Link LinkedList_Begin(LinkedList *linkedlist) //맨 앞에 있는 노드 자료 위치
{
	//연결리스트의 head가 가리키는 노드는 더미 노드이며 head의 next가 가리키는 노드가 자료를 보관한 맨 앞의 노드입니다.
	return linkedlist->head->next;
}

Link LinkedList_End(LinkedList *linkedlist) //맨 뒤에 있는 노드 자료 위치
{
	//언제나 맨 마지막 보관한 자료를 보관한 노드의 다음 노드가 tail입니다.
	return linkedlist->tail;
}


void DisconnectNode(Link pos)
{
	//연결을 끊을 노드의 이전(prev) 노드의 next를 연결을 끊을 노드의 이후(next) 노드로 설정합니다.
	pos->prev->next = pos->next;
	//연결을 끊을 노드의 이후(next) 노드의 prev를 연견을 끊을 노드의 이전(prev) 노드로 설정합니다.
	pos->next->prev = pos->prev;
}

void LinkedList_Erase(LinkedList *linkedlist, Link pos) //특정 위치의 노드 제거
{
	//먼저 연결을 끊습니다. 이 부분은 별도의 함수로 작성합시다.
	DisconnectNode(pos);
	//그리고 노드를 위해 할당한 메모리를 해제하고 보관한 자료 개수를 1 감소합니다.
	free(pos);
	linkedlist->usage--;
}


#pragma once
/*동적 배열처럼 연결리스트도 동적으로 생성한 개체는 형식에 관계없이 보관할
수 있게 정의합니다.. 사용하기 편리하게 void * 형식을 Element 형식으로 타입 재지정합니다.*/
typedef int Element;

/* 연결리스트는 노드의 선형 집합입니다. 노드는 링크와 데이터의 조합으로
여기에서는 두 개의 링크를 갖는 노드를 정의할 것입니다.*/
typedef struct _Node Node;
typedef Node *Link;
struct _Node
{
	Link next;
	Link prev;
	Element data;
};

/*연결리스트 구조체에는 맨 앞에 있는 더미 노드의 위치 정보인 head와
맨 뒤에 있는 더미 노드의 위치 정보인 tail과 보관한 자료 개수를 멤버로 구성합니다.*/
typedef struct _LinkedList LinkedList;
struct _LinkedList
{
	Link head;
	Link tail;
	int usage;
};

LinkedList *New_LinkedList(); //연결리스트 동적생성
void Delete_LinkedList(LinkedList *linkedlist); //연결리스트 삭제
void LinkedList_PushBack(LinkedList *linkedlist, Element data); //연결리스트 순차적 보관
void LinkedList_Insert(LinkedList *linkedlist, Link pos, Element data); //원하는 노드앞에 삽입
Link LinkedList_Begin(LinkedList *linkedlist); //맨 앞에 있는 노드 자료 위치
Link LinkedList_End(LinkedList *linkedlist); //맨 뒤에 있는 노드 자료 위치
void LinkedList_Erase(LinkedList *linkedlist, Link pos); //특정 위치의 노드 제거
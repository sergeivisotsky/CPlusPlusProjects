#include "variables.h"
#include "stdafx.h"
#include "iostream"
#include "string"

using namespace std;

struct Node
{
	int data;
	struct Node *next;
};

class LinkedList {
private:
	Node *head;
	Node *tail;

	LinkedList() {
		head = null;
		tail = null;
	}

public:

	void insert(int element) {
		Node* node = new Node(malloc(sizeof(struct Node)));
		size++;
	}

	void display() {

	}

	void deleteElement(int position) {

	}

	int getSize() {
		return size;
	}

	int isFull() {
		return size == 10;
	}
};

int main() {
	int answer_number;
	int element;
	string yes_no_answer;
	LinkedList list = new LinkedList();
	do
	{
		cout << "1: insert" << endl;
		cout << "2: display" << endl;
		cout << "3: delete" << endl;
		cout << "4: isFull?" << endl;
		cout << "5: isEmpty" << endl;
		cout << "6: getSize" << endl;
		cout << "Answer: ";
		cin >> answer_number;
		switch (answer_number)
		{
		case 1:
			if (!list.isFull())
			{
				cout << "Element: ";
				list->insert(element);
			}
			else {
				cout << "List is full!" << endl;
			}
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		default:
			throw new runtime_error("Incorrect answer!");
		}

		cout << "Continue? (y/n) ";
		cin >> yes_no_answer;
	} while (yes_no_answer == "y" || yes_no_answer == "Y");

	return 0;
}

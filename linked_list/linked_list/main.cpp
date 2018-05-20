#include "iostream";
#include <string>;

using namespace std;

struct Node {
	int data;
	Node *next;

	Node(int data) : data(data) {}
};

class LinkedList {
	Node *ptr{};
private:
	Node * head, *tail;
	int size = 0;
	int max_size;

public:
	LinkedList() {
		head = nullptr;
		tail = nullptr;
	}

	LinkedList(int _max_size) : max_size(_max_size) {}

	void insertAtStart(int element) {
		Node *node = new Node(element);
		node->next = head;
		tail->next = node;
		head = node;
	}

	void insertInTheMiddle(int element) {
		Node *node, *temp, *ptr;
		node = new Node(element);
		temp = head;
		ptr = head->next;

		while (temp != tail) {
			if (element >= temp->data &&
				element <= ptr->data)
			{
				temp->next = node;
				node->next = ptr;
				break;
			}
			else {
				temp = ptr;
				ptr = ptr->next;
			}
		}
	}

	void insertAtTheEnd(int element) {
		Node *node = new Node(element);
		tail->next = node;
		node->next = head;
		tail = node;
	}

	void insert(int element) {
		Node *node = new Node(element);
		if (isEmpty())
		{
			head = node;
			node->next = head;
			tail = head;
		}
		else if (element <= head->data)
		{
			insertAtStart(element);
		}
		else if (element >= tail->data)
		{
			insertAtTheEnd(element);
		}
		else
		{
			insertInTheMiddle(element);
		}
		size++;
	}

	void display() {
		Node *node = head;
		if (isEmpty())
		{
			cout << "List is empty!";
			return;
		}

		if (head->next == head)
		{
			cout << head->data;
			return;
		}

		cout << head->data << "\t";
		node = head->next;

		while (node->next != head)
		{
			cout << node->data << "\t";
			node = node->next;
		}

		cout << node->data;
	}



	void deleteElement(int nodeIndex) {
		if (nodeIndex == 1 && size == 1)
		{
			head == nullptr;
			tail = nullptr;
			size = 0;
			return;
		}

		if (nodeIndex == 1)
		{
			head = head->next;
			tail->next = head;
			size--;
			return;
		}

		if (nodeIndex == size)
		{
			Node *node = head;
			for (int i = 0; i < size - 1; i++)
			{
				node = node->next;
			}

			node->next = head;
			tail = node;
			size--;
			return;
		}

		Node *node = head;
		nodeIndex--;
		for (int i = 0; i < size - 1; i++)
		{
			if (i == nodeIndex)
			{
				Node *temp = node->next;
				temp = temp->next;
				node->next = temp;
				break;
			}
			node = node->next;
		}
		size--;
	}

	int getSize() {
		return size;
	}

	int isFull() {
		return size == max_size;
	}

	bool isEmpty() {
		return size == 0;
	}

	~LinkedList() {

	}
};

int main() {
	int answer_number;
	int element;
	int index;
	char yes_no_answer;
	int list_size;
	cout << "List size (max 10):";
	cin >> list_size;
	if (list_size > 10)
	{
		throw new runtime_error("List should not be loner than 10 elements!");
	}
	LinkedList list(list_size);
	do {
		cout << "1: insert" << endl;
		cout << "2: delete" << endl;
		cout << "3: isFull?" << endl;
		cout << "4: isEmpty?" << endl;
		cout << "5: getSize" << endl;
		cout << "Answer: ";
		cin >> answer_number;
		switch (answer_number) {
		case 1:
			if (!list.isFull()) {
				cout << "Element: ";
				cin >> element;
				list.insert(element);
			}
			else {
				cout << "List is full!" << endl;
			}
			break;
		case 2:
			if (!list.isEmpty())
			{
				cout << "Index: ";
				cin >> index;
				list.deleteElement(index);
			}
			else
			{
				cout << "List is empty!" << endl;
			}
			break;
		case 3:
			cout << "Full status: " << list.isFull() << endl;
			break;
		case 4:
			cout << "Empty status: " << list.isEmpty() << endl;
			break;
		case 5:
			cout << "List size: " << list.getSize() << endl;
			break;
		default:
			throw new runtime_error("Incorrect answer!");
		}

		cout << "Created list: " << endl;
		list.display();
		cout << "\n" << "Continue? (y/n) ";
		cin >> yes_no_answer;
	} while (yes_no_answer == 'y' || yes_no_answer == 'Y');
	return 0;
}
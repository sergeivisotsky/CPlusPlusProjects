// bst_postorder.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "string"

using namespace std;

struct Node {
	int data;
	Node *left;
	Node *right;

	Node(int _data) : data(data) {};
	Node() = default;
};

class binary_search_tree {
private:
	Node root;
	int size;
	int max_size;
	
	Node insertWrapper(Node* node, int element) {
		if (node == NULL)
		{
			return Node(element);
		}

		Node *newSubtree;
		if (element < node->data)
		{
			*newSubtree = insertWrapper(node->left, element);
			node->left = newSubtree;
			return *node;
		}
		else if (element > node->data)
		{
			*newSubtree = insertWrapper(node->right, element);
			node->right = newSubtree;
			return *node;
		}

		return *node;
	}

public:
	binary_search_tree(int _max_size) : max_size(_max_size) {};
	int getSize() {
		return size;
	}

	bool isEmpty() {
		return size == 0;
	}

	bool isFull() {
		return size == max_size;
	}

	void insert(int element) {
		root = insertWrapper(&root, element);
		size++;
	}



};

void main()
{

}


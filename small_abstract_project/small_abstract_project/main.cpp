#include <iostream>
#include <string>
#include <list>

using namespace std;

// Testing class
class my_class {
private:
	list<int> new_list;

public:
	static void developer() {
		cout << "Hello world I am developer!" << endl;
	}

	void list_creation(int element) {
		new_list.push_front(element);
	}

	void display_list() {
		for (auto element : new_list)
		{
			cout << element << " ";
		}
		cout << "\n";
	}


};

// Working with template(generic) types
template <typename T> class second_new_class {
public:
	T hello(T first_word, T second_word) {
		cout << first_word + " " + second_word << endl;

		return 0;
	}
};


int main() {
	my_class* new_class = new my_class();
	my_class::developer();
	int element;

	for (auto i = 0; i < 3; i++)
	{
		cout << "Element: ";
		cin >> element;
		new_class->list_creation(element);
	}

	cout << "Created list: ";
	new_class->display_list();

	second_new_class<string> s_n_class;
	s_n_class.hello("Hello", "World");

	delete new_class;
	return 0;
}
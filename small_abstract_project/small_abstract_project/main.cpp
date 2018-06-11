#include <iostream>
#include <string>
#include <list>

using namespace std;

// Experimental class
class my_class {
private:
	list<int> new_list;
	int age;

public:
	int get_age() {
		return age;
	}

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
	T concat_data(T first_data, T second_data) {
		return first_data + second_data;
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

	second_new_class<string> string_concat;
	cout << string_concat.concat_data("Hello", "World") << endl;

	second_new_class<int> digit_concat;
	cout << digit_concat.concat_data(1, 2) << endl;

	second_new_class<double> char_concat;
	cout << char_concat.concat_data(5.988, 1.367) << endl;

	delete new_class;
	return 0;
}
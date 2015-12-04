#include <iostream>

class simple
{
public:
	int intVariable;
	simple()
	{
		intVariable = 1;
	}
	void increment(int intIncrementer)
	{
		intVariable+=intIncrementer;
	}
};

int main(){
	simple simpleTest;
	simpleTest.increment(2);
	std::cout << "Status of intVariable: " << simpleTest.intVariable ;
}


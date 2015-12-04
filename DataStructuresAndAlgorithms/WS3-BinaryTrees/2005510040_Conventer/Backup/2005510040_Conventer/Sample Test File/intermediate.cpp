#include <iostream>
#include <string>

class intermediate
{
private:
	int intVariable;
	std::string strVariable;
	
public:
	intermediate()
	{
		intVariable = 1;
		strVariable = "a";
	}
	void increment(int intIncrementer, std::string strIncrementer)
	{
		intVariable+=intIncrementer;
		strVariable+=strIncrementer;
	}
	int getIntVariable()
	{	
		return intVariable;
	}
	void setIntVariable(int newIntVariable)
    {
		if (newIntVariable)
		{
			intVariable= newIntVariable;
		}
    }
	std::string getStrVariable()
	{	
		return strVariable;
	}
	void setStrVariable(std::string newStrVariable)
    {
        strVariable= newStrVariable;
    }
};

int main(){
	int i;
	intermediate intermediateTest;
	for (i=0; i<5; i++)
	{
		intermediateTest.increment(i,"b");
		std::cout << "Status of intVariable: " << intermediateTest.getIntVariable() << "\nStatus of strVariable: " << intermediateTest.getStrVariable()<< std::endl << std::endl;
	}
	while (--i > 0)
	{
		intermediateTest.increment(i,"c");
		std::cout << "Status of intVariable: " << intermediateTest.getIntVariable() << "\nStatus of strVariable: " << intermediateTest.getStrVariable()<< std::endl << std::endl;
	}
}


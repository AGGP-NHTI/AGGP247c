
#include "pch.h"
#include <iostream>
#include <cstdlib>
using namespace std; 

bool NearlyEqual(float f1, float f2); 

int main()
{
	bool check1 = false;
	bool check2 = false;
	bool check3 = false;
	bool check4 = false;

	float f1 = 1.0f / 6.0f;				// 1/3
	float f2 = (f1 * 6.0f) - 1.0f;    
	float f3 = .1667f;					// 1/3 typed out to 3 places
	float fzero = 0.0f;					// Zero, Literal 


	if (fzero == f2)
	{
		check1 = true;
	}

	if (NearlyEqual(f2, fzero))
	{
		check2 = true;
	}

	if (f1 == f3)
	{
		check3 = true;
	}

	if (NearlyEqual(f1, f3))
	{
		check4 = true;
	}

	cout << "Float Check Application" << "\n\n";

	cout << "Check1: " << boolalpha << check1 << "\n";
	cout << "Check2: " << boolalpha << check2 << "\n";
	cout << "Check3: " << boolalpha << check3 << "\n";
	cout << "Check4: " << boolalpha << check4 << "\n";
	// std::boolalpha converts a bool from 1/0 output to a True\False like .ToString in C#


	cout << "\nPress any Key\n";
	cin.get();
	return 0; 
}

bool NearlyEqual(float f1, float f2)
{
	float check = f1 - f2;
	return (abs(check) < 0.001);
}



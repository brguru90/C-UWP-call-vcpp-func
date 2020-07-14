#pragma once

/*
#define Test_API __declspec(dllexport)


#define Dll1_EXPORTS

#ifdef Dll1_EXPORTS  
#define Test_API __declspec(dllexport)   
#else  
#define Test_API __declspec(dllimport)   
#endif 



extern "C" class Test_API testApi {
public:
	int add_func(int, int);
};

*/


class testApi {
public:
	int add_func(int, int);
};


extern "C" __declspec(dllexport)
int test(int a,int b)
{
	return (new testApi())->add_func(a, b);
}


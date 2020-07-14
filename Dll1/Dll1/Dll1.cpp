#include "pch.h"
#include "Dll1.h"

int testApi::add_func(int a, int b)
{
	return a + b;
}

/*
******************************references**********************

https://aticleworld.com/how-to-create-and-use-dll-dynamic-link-library-in-c/


------------steps------------
right click on project->Proerty->general->Consume window runtime extension= Yes (/ZW)

build x86 if c# app is x86(both should target to same architecture)



*/

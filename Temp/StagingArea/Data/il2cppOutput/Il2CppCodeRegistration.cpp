﻿#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>


#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"


extern const methodPointerType g_MethodPointers[];
extern const methodPointerType g_DelegateWrappersManagedToNative[];
extern const Il2CppMarshalingFunctions g_MarshalingFunctions[];
extern const methodPointerType g_Il2CppGenericMethodPointers[];
extern const InvokerMethod g_Il2CppInvokerPointers[];
extern const CustomAttributesCacheGenerator g_AttributeGenerators[];
const Il2CppCodeRegistration g_CodeRegistration = 
{
	10543,
	g_MethodPointers,
	0,
	NULL,
	49,
	g_DelegateWrappersManagedToNative,
	123,
	g_MarshalingFunctions,
	0,
	NULL,
	4172,
	g_Il2CppGenericMethodPointers,
	1560,
	g_Il2CppInvokerPointers,
	2324,
	g_AttributeGenerators,
	0,
	NULL,
};
extern const Il2CppMetadataRegistration g_MetadataRegistration;
static const Il2CppCodeGenOptions s_Il2CppCodeGenOptions = 
{
	false,
};
static void s_Il2CppCodegenRegistration()
{
	il2cpp_codegen_register (&g_CodeRegistration, &g_MetadataRegistration, &s_Il2CppCodeGenOptions);
}
static il2cpp::utils::RegisterRuntimeInitializeAndCleanup s_Il2CppCodegenRegistrationVariable (&s_Il2CppCodegenRegistration, NULL);
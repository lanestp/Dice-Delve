﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct Il2CppObject;
struct t3431720054;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1097883944  : public Il2CppObject
{
public:

public:
};

struct t1097883944_SFs
{
public:
	Il2CppObject * f0;
	t3431720054* f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1097883944_SFs, f0)); }
	inline Il2CppObject * fg0() const { return f0; }
	inline Il2CppObject ** fag0() { return &f0; }
	inline void fs0(Il2CppObject * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t1097883944_SFs, f1)); }
	inline t3431720054* fg1() const { return f1; }
	inline t3431720054** fag1() { return &f1; }
	inline void fs1(t3431720054* value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

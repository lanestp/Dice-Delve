﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct Il2CppObject;
struct t1103364673;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4212379933  : public Il2CppObject
{
public:
	int32_t f0;
	Il2CppObject * f1;
	t1103364673 * f2;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t4212379933, f0)); }
	inline int32_t fg0() const { return f0; }
	inline int32_t* fag0() { return &f0; }
	inline void fs0(int32_t value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t4212379933, f1)); }
	inline Il2CppObject * fg1() const { return f1; }
	inline Il2CppObject ** fag1() { return &f1; }
	inline void fs1(Il2CppObject * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t4212379933, f2)); }
	inline t1103364673 * fg2() const { return f2; }
	inline t1103364673 ** fag2() { return &f2; }
	inline void fs2(t1103364673 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1905726208;
struct t4063666527;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2900260814  : public Il2CppObject
{
public:

public:
};

struct t2900260814_SFs
{
public:
	t1905726208 * f0;
	t4063666527 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2900260814_SFs, f0)); }
	inline t1905726208 * fg0() const { return f0; }
	inline t1905726208 ** fag0() { return &f0; }
	inline void fs0(t1905726208 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2900260814_SFs, f1)); }
	inline t4063666527 * fg1() const { return f1; }
	inline t4063666527 ** fag1() { return &f1; }
	inline void fs1(t4063666527 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

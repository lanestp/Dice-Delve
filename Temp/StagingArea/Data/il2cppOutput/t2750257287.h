﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t284553113;

#include "Il2CppObject.h"
#include "t1891715979.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2750257287  : public Il2CppObject
{
public:
	t1891715979  f0;
	t284553113 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2750257287, f0)); }
	inline t1891715979  fg0() const { return f0; }
	inline t1891715979 * fag0() { return &f0; }
	inline void fs0(t1891715979  value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2750257287, f1)); }
	inline t284553113 * fg1() const { return f1; }
	inline t284553113 ** fag1() { return &f1; }
	inline void fs1(t284553113 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

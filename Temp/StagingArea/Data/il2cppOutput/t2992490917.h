﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t4175053208;

#include "Il2CppObject.h"
#include "t318735129.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2992490917  : public Il2CppObject
{
public:
	int32_t f0;
	int32_t f1;
	t318735129  f2;
	t4175053208 * f3;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2992490917, f0)); }
	inline int32_t fg0() const { return f0; }
	inline int32_t* fag0() { return &f0; }
	inline void fs0(int32_t value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2992490917, f1)); }
	inline int32_t fg1() const { return f1; }
	inline int32_t* fag1() { return &f1; }
	inline void fs1(int32_t value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t2992490917, f2)); }
	inline t318735129  fg2() const { return f2; }
	inline t318735129 * fag2() { return &f2; }
	inline void fs2(t318735129  value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t2992490917, f3)); }
	inline t4175053208 * fg3() const { return f3; }
	inline t4175053208 ** fag3() { return &f3; }
	inline void fs3(t4175053208 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1557563107;
struct t58506160;
struct t190145395;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4287420181  : public Il2CppObject
{
public:
	t1557563107 * f0;
	t58506160* f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t4287420181, f0)); }
	inline t1557563107 * fg0() const { return f0; }
	inline t1557563107 ** fag0() { return &f0; }
	inline void fs0(t1557563107 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t4287420181, f1)); }
	inline t58506160* fg1() const { return f1; }
	inline t58506160** fag1() { return &f1; }
	inline void fs1(t58506160* value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

struct t4287420181_SFs
{
public:
	t190145395 * f2;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t4287420181_SFs, f2)); }
	inline t190145395 * fg2() const { return f2; }
	inline t190145395 ** fag2() { return &f2; }
	inline void fs2(t190145395 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

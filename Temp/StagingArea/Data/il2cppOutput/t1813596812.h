﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t4014882752.h"
#include "t2936663476.h"
#include "t3652844660.h"
#include "t3525329789.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1813596812 
{
public:
	int32_t f0;
	int32_t f1;
	t3525329789  f2;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1813596812, f0)); }
	inline int32_t fg0() const { return f0; }
	inline int32_t* fag0() { return &f0; }
	inline void fs0(int32_t value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t1813596812, f1)); }
	inline int32_t fg1() const { return f1; }
	inline int32_t* fag1() { return &f1; }
	inline void fs1(int32_t value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1813596812, f2)); }
	inline t3525329789  fg2() const { return f2; }
	inline t3525329789 * fag2() { return &f2; }
	inline void fs2(t3525329789  value)
	{
		f2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: DG.Tweening.Plugins.Options.QuaternionOptions
struct t1813596812_marshaled_pinvoke
{
	int32_t f0;
	int32_t f1;
	t3525329789_marshaled_pinvoke f2;
};
// Native definition for marshalling of: DG.Tweening.Plugins.Options.QuaternionOptions
struct t1813596812_marshaled_com
{
	int32_t f0;
	int32_t f1;
	t3525329789_marshaled_com f2;
};
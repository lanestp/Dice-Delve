﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t4014882752.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1160272134 
{
public:
	bool f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1160272134, f0)); }
	inline bool fg0() const { return f0; }
	inline bool* fag0() { return &f0; }
	inline void fs0(bool value)
	{
		f0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: DG.Tweening.Plugins.Options.RectOptions
struct t1160272134_marshaled_pinvoke
{
	int32_t f0;
};
// Native definition for marshalling of: DG.Tweening.Plugins.Options.RectOptions
struct t1160272134_marshaled_com
{
	int32_t f0;
};
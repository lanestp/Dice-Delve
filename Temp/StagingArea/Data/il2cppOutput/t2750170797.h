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

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2750170797  : public Il2CppObject
{
public:
	t284553113 * f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2750170797, f0)); }
	inline t284553113 * fg0() const { return f0; }
	inline t284553113 ** fag0() { return &f0; }
	inline void fs0(t284553113 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

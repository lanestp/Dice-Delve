#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3822575854;
struct t3575665668;

#include "t1993456272.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3896752800  : public t1993456272
{
public:

public:
};

struct t3896752800_SFs
{
public:
	t3822575854 * f0;
	t3575665668 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t3896752800_SFs, f0)); }
	inline t3822575854 * fg0() const { return f0; }
	inline t3822575854 ** fag0() { return &f0; }
	inline void fs0(t3822575854 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t3896752800_SFs, f1)); }
	inline t3575665668 * fg1() const { return f1; }
	inline t3575665668 ** fag1() { return &f1; }
	inline void fs1(t3575665668 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

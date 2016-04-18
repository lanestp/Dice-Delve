#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1900323642;
struct t3395674658;

#include "t1103364673.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2436335575  : public t1103364673
{
public:
	t1900323642 * f51;
	t3395674658 * f52;
	float f53;

public:
	inline static int32_t fog51() { return static_cast<int32_t>(offsetof(t2436335575, f51)); }
	inline t1900323642 * fg51() const { return f51; }
	inline t1900323642 ** fag51() { return &f51; }
	inline void fs51(t1900323642 * value)
	{
		f51 = value;
		Il2CppCodeGenWriteBarrier(&f51, value);
	}

	inline static int32_t fog52() { return static_cast<int32_t>(offsetof(t2436335575, f52)); }
	inline t3395674658 * fg52() const { return f52; }
	inline t3395674658 ** fag52() { return &f52; }
	inline void fs52(t3395674658 * value)
	{
		f52 = value;
		Il2CppCodeGenWriteBarrier(&f52, value);
	}

	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t2436335575, f53)); }
	inline float fg53() const { return f53; }
	inline float* fag53() { return &f53; }
	inline void fs53(float value)
	{
		f53 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

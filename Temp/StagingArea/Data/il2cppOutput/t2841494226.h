#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3947337298;
struct t689009830;
struct t3734373201;

#include "t1766303790.h"
#include "t3779806670.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2841494226  : public t1766303790
{
public:
	float f53;
	float f54;
	float f55;
	t3779806670  f56;
	t3947337298 * f57;
	t689009830 * f58;
	t3734373201 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t2841494226, f53)); }
	inline float fg53() const { return f53; }
	inline float* fag53() { return &f53; }
	inline void fs53(float value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t2841494226, f54)); }
	inline float fg54() const { return f54; }
	inline float* fag54() { return &f54; }
	inline void fs54(float value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t2841494226, f55)); }
	inline float fg55() const { return f55; }
	inline float* fag55() { return &f55; }
	inline void fs55(float value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t2841494226, f56)); }
	inline t3779806670  fg56() const { return f56; }
	inline t3779806670 * fag56() { return &f56; }
	inline void fs56(t3779806670  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t2841494226, f57)); }
	inline t3947337298 * fg57() const { return f57; }
	inline t3947337298 ** fag57() { return &f57; }
	inline void fs57(t3947337298 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t2841494226, f58)); }
	inline t689009830 * fg58() const { return f58; }
	inline t689009830 ** fag58() { return &f58; }
	inline void fs58(t689009830 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t2841494226, f59)); }
	inline t3734373201 * fg59() const { return f59; }
	inline t3734373201 ** fag59() { return &f59; }
	inline void fs59(t3734373201 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

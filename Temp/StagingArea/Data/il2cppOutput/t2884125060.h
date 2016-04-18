#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t437523947;
struct Il2CppObject;
struct t3041755685;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2884125060  : public Il2CppObject
{
public:
	t437523947 * f0;
	int32_t f1;
	Il2CppObject * f2;
	t437523947 * f3;
	t3041755685 * f4;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2884125060, f0)); }
	inline t437523947 * fg0() const { return f0; }
	inline t437523947 ** fag0() { return &f0; }
	inline void fs0(t437523947 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2884125060, f1)); }
	inline int32_t fg1() const { return f1; }
	inline int32_t* fag1() { return &f1; }
	inline void fs1(int32_t value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t2884125060, f2)); }
	inline Il2CppObject * fg2() const { return f2; }
	inline Il2CppObject ** fag2() { return &f2; }
	inline void fs2(Il2CppObject * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t2884125060, f3)); }
	inline t437523947 * fg3() const { return f3; }
	inline t437523947 ** fag3() { return &f3; }
	inline void fs3(t437523947 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t2884125060, f4)); }
	inline t3041755685 * fg4() const { return f4; }
	inline t3041755685 ** fag4() { return &f4; }
	inline void fs4(t3041755685 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

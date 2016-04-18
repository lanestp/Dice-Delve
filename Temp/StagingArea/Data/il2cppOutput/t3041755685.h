#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t943604531;
struct t1092684080;
struct t4012695102;

#include "t3012272455.h"
#include "t3525329789.h"
#include "t1041377121.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3041755685  : public t3012272455
{
public:
	t943604531 * f2;
	t1092684080 * f3;
	t4012695102 * f4;
	bool f5;
	t3525329789  f6;
	int32_t f7;
	int32_t f8;
	bool f9;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3041755685, f2)); }
	inline t943604531 * fg2() const { return f2; }
	inline t943604531 ** fag2() { return &f2; }
	inline void fs2(t943604531 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3041755685, f3)); }
	inline t1092684080 * fg3() const { return f3; }
	inline t1092684080 ** fag3() { return &f3; }
	inline void fs3(t1092684080 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t3041755685, f4)); }
	inline t4012695102 * fg4() const { return f4; }
	inline t4012695102 ** fag4() { return &f4; }
	inline void fs4(t4012695102 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t3041755685, f5)); }
	inline bool fg5() const { return f5; }
	inline bool* fag5() { return &f5; }
	inline void fs5(bool value)
	{
		f5 = value;
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t3041755685, f6)); }
	inline t3525329789  fg6() const { return f6; }
	inline t3525329789 * fag6() { return &f6; }
	inline void fs6(t3525329789  value)
	{
		f6 = value;
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t3041755685, f7)); }
	inline int32_t fg7() const { return f7; }
	inline int32_t* fag7() { return &f7; }
	inline void fs7(int32_t value)
	{
		f7 = value;
	}

	inline static int32_t fog8() { return static_cast<int32_t>(offsetof(t3041755685, f8)); }
	inline int32_t fg8() const { return f8; }
	inline int32_t* fag8() { return &f8; }
	inline void fs8(int32_t value)
	{
		f8 = value;
	}

	inline static int32_t fog9() { return static_cast<int32_t>(offsetof(t3041755685, f9)); }
	inline bool fg9() const { return f9; }
	inline bool* fag9() { return &f9; }
	inline void fs9(bool value)
	{
		f9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

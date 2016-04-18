#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2344470377;

#include "t3041755685.h"
#include "t953806530.h"
#include "t1041377121.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t67100520  : public t3041755685
{
public:
	int32_t f10;
	t2344470377 * f11;
	int32_t f12;
	int32_t f13;

public:
	inline static int32_t fog10() { return static_cast<int32_t>(offsetof(t67100520, f10)); }
	inline int32_t fg10() const { return f10; }
	inline int32_t* fag10() { return &f10; }
	inline void fs10(int32_t value)
	{
		f10 = value;
	}

	inline static int32_t fog11() { return static_cast<int32_t>(offsetof(t67100520, f11)); }
	inline t2344470377 * fg11() const { return f11; }
	inline t2344470377 ** fag11() { return &f11; }
	inline void fs11(t2344470377 * value)
	{
		f11 = value;
		Il2CppCodeGenWriteBarrier(&f11, value);
	}

	inline static int32_t fog12() { return static_cast<int32_t>(offsetof(t67100520, f12)); }
	inline int32_t fg12() const { return f12; }
	inline int32_t* fag12() { return &f12; }
	inline void fs12(int32_t value)
	{
		f12 = value;
	}

	inline static int32_t fog13() { return static_cast<int32_t>(offsetof(t67100520, f13)); }
	inline int32_t fg13() const { return f13; }
	inline int32_t* fag13() { return &f13; }
	inline void fs13(int32_t value)
	{
		f13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

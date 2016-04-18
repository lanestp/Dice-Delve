#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1092684080;

#include "t3012272455.h"
#include "t3669764745.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t426579631  : public t3012272455
{
public:
	int32_t f2;
	t1092684080 * f3;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t426579631, f2)); }
	inline int32_t fg2() const { return f2; }
	inline int32_t* fag2() { return &f2; }
	inline void fs2(int32_t value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t426579631, f3)); }
	inline t1092684080 * fg3() const { return f3; }
	inline t1092684080 ** fag3() { return &f3; }
	inline void fs3(t1092684080 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

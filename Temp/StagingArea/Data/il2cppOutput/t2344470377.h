#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t679069995;
struct t4177078322;
struct t1092684080;

#include "t3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2344470377  : public t3012272455
{
public:
	t679069995 * f2;
	t4177078322 * f3;
	t1092684080 * f4;
	int32_t f5;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t2344470377, f2)); }
	inline t679069995 * fg2() const { return f2; }
	inline t679069995 ** fag2() { return &f2; }
	inline void fs2(t679069995 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t2344470377, f3)); }
	inline t4177078322 * fg3() const { return f3; }
	inline t4177078322 ** fag3() { return &f3; }
	inline void fs3(t4177078322 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t2344470377, f4)); }
	inline t1092684080 * fg4() const { return f4; }
	inline t1092684080 ** fag4() { return &f4; }
	inline void fs4(t1092684080 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t2344470377, f5)); }
	inline int32_t fg5() const { return f5; }
	inline int32_t* fag5() { return &f5; }
	inline void fs5(int32_t value)
	{
		f5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

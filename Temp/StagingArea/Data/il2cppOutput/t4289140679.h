#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t282336741;
struct t1318976569;
struct t887052358;

#include "t1766303790.h"
#include "t1588175760.h"
#include "t4161000167.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4289140679  : public t1766303790
{
public:
	t1588175760  f53;
	t1588175760  f54;
	t1588175760  f55;
	t4161000167  f56;
	t282336741 * f57;
	t1318976569 * f58;
	t887052358 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t4289140679, f53)); }
	inline t1588175760  fg53() const { return f53; }
	inline t1588175760 * fag53() { return &f53; }
	inline void fs53(t1588175760  value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t4289140679, f54)); }
	inline t1588175760  fg54() const { return f54; }
	inline t1588175760 * fag54() { return &f54; }
	inline void fs54(t1588175760  value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t4289140679, f55)); }
	inline t1588175760  fg55() const { return f55; }
	inline t1588175760 * fag55() { return &f55; }
	inline void fs55(t1588175760  value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t4289140679, f56)); }
	inline t4161000167  fg56() const { return f56; }
	inline t4161000167 * fag56() { return &f56; }
	inline void fs56(t4161000167  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t4289140679, f57)); }
	inline t282336741 * fg57() const { return f57; }
	inline t282336741 ** fag57() { return &f57; }
	inline void fs57(t282336741 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t4289140679, f58)); }
	inline t1318976569 * fg58() const { return f58; }
	inline t1318976569 ** fag58() { return &f58; }
	inline void fs58(t1318976569 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t4289140679, f59)); }
	inline t887052358 * fg59() const { return f59; }
	inline t887052358 ** fag59() { return &f59; }
	inline void fs59(t887052358 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

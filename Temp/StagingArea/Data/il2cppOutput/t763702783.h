#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2219490771;
struct t3256130599;
struct t1656581758;

#include "t1766303790.h"
#include "t3525329790.h"
#include "t3308462279.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t763702783  : public t1766303790
{
public:
	t3525329790  f53;
	t3525329790  f54;
	t3525329790  f55;
	t3308462279  f56;
	t2219490771 * f57;
	t3256130599 * f58;
	t1656581758 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t763702783, f53)); }
	inline t3525329790  fg53() const { return f53; }
	inline t3525329790 * fag53() { return &f53; }
	inline void fs53(t3525329790  value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t763702783, f54)); }
	inline t3525329790  fg54() const { return f54; }
	inline t3525329790 * fag54() { return &f54; }
	inline void fs54(t3525329790  value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t763702783, f55)); }
	inline t3525329790  fg55() const { return f55; }
	inline t3525329790 * fag55() { return &f55; }
	inline void fs55(t3525329790  value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t763702783, f56)); }
	inline t3308462279  fg56() const { return f56; }
	inline t3308462279 * fag56() { return &f56; }
	inline void fs56(t3308462279  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t763702783, f57)); }
	inline t2219490771 * fg57() const { return f57; }
	inline t2219490771 ** fag57() { return &f57; }
	inline void fs57(t2219490771 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t763702783, f58)); }
	inline t3256130599 * fg58() const { return f58; }
	inline t3256130599 ** fag58() { return &f58; }
	inline void fs58(t3256130599 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t763702783, f59)); }
	inline t1656581758 * fg59() const { return f59; }
	inline t1656581758 ** fag59() { return &f59; }
	inline void fs59(t1656581758 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

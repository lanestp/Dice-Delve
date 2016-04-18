#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3523644891;
struct t265317423;
struct t2856278496;

#include "t1766303790.h"
#include "t32144009.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1963399521  : public t1766303790
{
public:
	double f53;
	double f54;
	double f55;
	t32144009  f56;
	t3523644891 * f57;
	t265317423 * f58;
	t2856278496 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t1963399521, f53)); }
	inline double fg53() const { return f53; }
	inline double* fag53() { return &f53; }
	inline void fs53(double value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t1963399521, f54)); }
	inline double fg54() const { return f54; }
	inline double* fag54() { return &f54; }
	inline void fs54(double value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t1963399521, f55)); }
	inline double fg55() const { return f55; }
	inline double* fag55() { return &f55; }
	inline void fs55(double value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t1963399521, f56)); }
	inline t32144009  fg56() const { return f56; }
	inline t32144009 * fag56() { return &f56; }
	inline void fs56(t32144009  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t1963399521, f57)); }
	inline t3523644891 * fg57() const { return f57; }
	inline t3523644891 ** fag57() { return &f57; }
	inline void fs57(t3523644891 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t1963399521, f58)); }
	inline t265317423 * fg58() const { return f58; }
	inline t265317423 ** fag58() { return &f58; }
	inline void fs58(t265317423 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t1963399521, f59)); }
	inline t2856278496 * fg59() const { return f59; }
	inline t2856278496 ** fag59() { return &f59; }
	inline void fs59(t2856278496 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

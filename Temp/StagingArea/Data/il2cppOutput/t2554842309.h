#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1541575768;
struct t2578215596;
struct t3447721284;

#include "t1766303790.h"
#include "t32144009.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2554842309  : public t1766303790
{
public:
	int32_t f53;
	int32_t f54;
	int32_t f55;
	t32144009  f56;
	t1541575768 * f57;
	t2578215596 * f58;
	t3447721284 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t2554842309, f53)); }
	inline int32_t fg53() const { return f53; }
	inline int32_t* fag53() { return &f53; }
	inline void fs53(int32_t value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t2554842309, f54)); }
	inline int32_t fg54() const { return f54; }
	inline int32_t* fag54() { return &f54; }
	inline void fs54(int32_t value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t2554842309, f55)); }
	inline int32_t fg55() const { return f55; }
	inline int32_t* fag55() { return &f55; }
	inline void fs55(int32_t value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t2554842309, f56)); }
	inline t32144009  fg56() const { return f56; }
	inline t32144009 * fag56() { return &f56; }
	inline void fs56(t32144009  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t2554842309, f57)); }
	inline t1541575768 * fg57() const { return f57; }
	inline t1541575768 ** fag57() { return &f57; }
	inline void fs57(t1541575768 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t2554842309, f58)); }
	inline t2578215596 * fg58() const { return f58; }
	inline t2578215596 ** fag58() { return &f58; }
	inline void fs58(t2578215596 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t2554842309, f59)); }
	inline t3447721284 * fg59() const { return f59; }
	inline t3447721284 ** fag59() { return &f59; }
	inline void fs59(t3447721284 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

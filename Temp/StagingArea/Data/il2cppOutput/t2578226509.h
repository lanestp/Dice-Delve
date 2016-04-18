#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3975053698;
struct t716726230;
struct t3471105484;

#include "t1766303790.h"
#include "t32144009.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2578226509  : public t1766303790
{
public:
	uint64_t f53;
	uint64_t f54;
	uint64_t f55;
	t32144009  f56;
	t3975053698 * f57;
	t716726230 * f58;
	t3471105484 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t2578226509, f53)); }
	inline uint64_t fg53() const { return f53; }
	inline uint64_t* fag53() { return &f53; }
	inline void fs53(uint64_t value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t2578226509, f54)); }
	inline uint64_t fg54() const { return f54; }
	inline uint64_t* fag54() { return &f54; }
	inline void fs54(uint64_t value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t2578226509, f55)); }
	inline uint64_t fg55() const { return f55; }
	inline uint64_t* fag55() { return &f55; }
	inline void fs55(uint64_t value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t2578226509, f56)); }
	inline t32144009  fg56() const { return f56; }
	inline t32144009 * fag56() { return &f56; }
	inline void fs56(t32144009  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t2578226509, f57)); }
	inline t3975053698 * fg57() const { return f57; }
	inline t3975053698 ** fag57() { return &f57; }
	inline void fs57(t3975053698 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t2578226509, f58)); }
	inline t716726230 * fg58() const { return f58; }
	inline t716726230 ** fag58() { return &f58; }
	inline void fs58(t716726230 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t2578226509, f59)); }
	inline t3471105484 * fg59() const { return f59; }
	inline t3471105484 ** fag59() { return &f59; }
	inline void fs59(t3471105484 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

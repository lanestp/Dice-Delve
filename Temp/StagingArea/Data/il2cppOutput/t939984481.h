#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1219431280;

#include "t4014882752.h"
#include "t3652844660.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t939984481 
{
public:
	int32_t f0;
	bool f1;
	t1219431280* f2;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t939984481, f0)); }
	inline int32_t fg0() const { return f0; }
	inline int32_t* fag0() { return &f0; }
	inline void fs0(int32_t value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t939984481, f1)); }
	inline bool fg1() const { return f1; }
	inline bool* fag1() { return &f1; }
	inline void fs1(bool value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t939984481, f2)); }
	inline t1219431280* fg2() const { return f2; }
	inline t1219431280** fag2() { return &f2; }
	inline void fs2(t1219431280* value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: DG.Tweening.Plugins.Options.Vector3ArrayOptions
struct t939984481_marshaled_pinvoke
{
	int32_t f0;
	int32_t f1;
	float* f2;
};
// Native definition for marshalling of: DG.Tweening.Plugins.Options.Vector3ArrayOptions
struct t939984481_marshaled_com
{
	int32_t f0;
	int32_t f1;
	float* f2;
};

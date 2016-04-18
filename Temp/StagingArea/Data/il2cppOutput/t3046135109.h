#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t4014882752.h"
#include "t1588175760.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3046135109 
{
public:
	t1588175760  f0;
	t1588175760  f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t3046135109, f0)); }
	inline t1588175760  fg0() const { return f0; }
	inline t1588175760 * fag0() { return &f0; }
	inline void fs0(t1588175760  value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t3046135109, f1)); }
	inline t1588175760  fg1() const { return f1; }
	inline t1588175760 * fag1() { return &f1; }
	inline void fs1(t1588175760  value)
	{
		f1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: DG.Tweening.Color2
struct t3046135109_marshaled_pinvoke
{
	t1588175760_marshaled_pinvoke f0;
	t1588175760_marshaled_pinvoke f1;
};
// Native definition for marshalling of: DG.Tweening.Color2
struct t3046135109_marshaled_com
{
	t1588175760_marshaled_com f0;
	t1588175760_marshaled_com f1;
};

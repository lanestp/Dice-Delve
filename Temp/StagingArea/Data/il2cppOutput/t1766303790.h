#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t1103364673.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1766303790  : public t1103364673
{
public:
	bool f51;
	bool f52;

public:
	inline static int32_t fog51() { return static_cast<int32_t>(offsetof(t1766303790, f51)); }
	inline bool fg51() const { return f51; }
	inline bool* fag51() { return &f51; }
	inline void fs51(bool value)
	{
		f51 = value;
	}

	inline static int32_t fog52() { return static_cast<int32_t>(offsetof(t1766303790, f52)); }
	inline bool fg52() const { return f52; }
	inline bool* fag52() { return &f52; }
	inline void fs52(bool value)
	{
		f52 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

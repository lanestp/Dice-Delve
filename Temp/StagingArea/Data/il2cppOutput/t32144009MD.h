#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>


#include "codegen/il2cpp-codegen.h"


struct t32144009;
struct t32144009_marshaled_pinvoke;

extern "C" void t32144009_marshal_pinvoke(const t32144009& unmarshaled, t32144009_marshaled_pinvoke& marshaled);
extern "C" void t32144009_marshal_pinvoke_back(const t32144009_marshaled_pinvoke& marshaled, t32144009& unmarshaled);
extern "C" void t32144009_marshal_pinvoke_cleanup(t32144009_marshaled_pinvoke& marshaled);

struct t32144009;
struct t32144009_marshaled_com;

extern "C" void t32144009_marshal_com(const t32144009& unmarshaled, t32144009_marshaled_com& marshaled);
extern "C" void t32144009_marshal_com_back(const t32144009_marshaled_com& marshaled, t32144009& unmarshaled);
extern "C" void t32144009_marshal_com_cleanup(t32144009_marshaled_com& marshaled);

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


struct t1160272134;
struct t1160272134_marshaled_pinvoke;

extern "C" void t1160272134_marshal_pinvoke(const t1160272134& unmarshaled, t1160272134_marshaled_pinvoke& marshaled);
extern "C" void t1160272134_marshal_pinvoke_back(const t1160272134_marshaled_pinvoke& marshaled, t1160272134& unmarshaled);
extern "C" void t1160272134_marshal_pinvoke_cleanup(t1160272134_marshaled_pinvoke& marshaled);

struct t1160272134;
struct t1160272134_marshaled_com;

extern "C" void t1160272134_marshal_com(const t1160272134& unmarshaled, t1160272134_marshaled_com& marshaled);
extern "C" void t1160272134_marshal_com_back(const t1160272134_marshaled_com& marshaled, t1160272134& unmarshaled);
extern "C" void t1160272134_marshal_com_cleanup(t1160272134_marshaled_com& marshaled);

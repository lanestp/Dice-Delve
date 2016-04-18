#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


struct t67100520;
struct t426579631;
struct t146645562;

#include "Il2CppArray.h"
#include "t67100520.h"
#include "t426579631.h"
#include "t146645562.h"

#pragma once
struct t3805539833  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t67100520 * m_Items[1];

public:
	inline t67100520 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t67100520 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t67100520 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t328410550  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t426579631 * m_Items[1];

public:
	inline t426579631 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t426579631 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t426579631 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t1065778079  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t146645562 * m_Items[1];

public:
	inline t146645562 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t146645562 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t146645562 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};

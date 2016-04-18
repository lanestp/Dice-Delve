#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


struct t3786476454;
struct t1103364673;
struct t2598715689;

#include "Il2CppArray.h"
#include "t3786476454.h"
#include "t1103364673.h"
#include "t2598715689.h"

#pragma once
struct t2750415619  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t3786476454 * m_Items[1];

public:
	inline t3786476454 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t3786476454 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t3786476454 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t2610237340  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t1103364673 * m_Items[1];

public:
	inline t1103364673 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t1103364673 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t1103364673 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t3009720340  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t2598715689 * m_Items[1];

public:
	inline t2598715689 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t2598715689 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t2598715689 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};

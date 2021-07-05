﻿#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"

struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
struct GenericVirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericVirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericInterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};

// System.ArgumentException
struct ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1;
// System.AsyncCallback
struct AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4;
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.Collections.IDictionary
struct IDictionary_t1BD5C1546718A374EA8122FBD6C6EE45331E8CE7;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE;
// System.Delegate[]
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196;
// System.IAsyncResult
struct IAsyncResult_t8E194308510B375B42432981AE5E7488C458D598;
// System.IntPtr[]
struct IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD;
// System.NullReferenceException
struct NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC;
// System.Reflection.Binder
struct Binder_t4D5CB06963501D32847C057B57157D6DC49CA759;
// System.Reflection.MemberFilter
struct MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770;
// System.Single[]
struct SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5;
// System.String
struct String_t;
// System.Type
struct Type_t;
// System.Type[]
struct TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F;
// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;
// UnityEngine.AnimationCurve
struct AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C;
// UnityEngine.Audio.AudioMixerGroup
struct AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9;
// UnityEngine.AudioBehaviour
struct AudioBehaviour_tC612EC4E17A648A5C568621F3FBF1DBD773C71C7;
// UnityEngine.AudioClip
struct AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051;
// UnityEngine.AudioClip/PCMReaderCallback
struct PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB;
// UnityEngine.AudioClip/PCMSetPositionCallback
struct PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801;
// UnityEngine.AudioSettings/AudioConfigurationChangeHandler
struct AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926;
// UnityEngine.AudioSource
struct AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C;
// UnityEngine.Behaviour
struct Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8;
// UnityEngine.Component
struct Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621;
// UnityEngine.Experimental.Audio.AudioSampleProvider
struct AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913;
// UnityEngine.Experimental.Audio.AudioSampleProvider/SampleFramesHandler
struct SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF;
// UnityEngine.GameObject
struct GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F;
// UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0;
// UnityEngine.Transform
struct Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA;

IL2CPP_EXTERN_C RuntimeClass* ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Boolean_tB53F6830F670160873277339AA58F15CAED4399C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt32_t4980FA09003AFAAB5A6E361BA2748EA9A005709B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral2C64ADC2791F15C91AD9F9389A373F05AA662698;
IL2CPP_EXTERN_C String_t* _stringLiteral2F43397615CF615962F130AA6604F6D76A60AE5C;
IL2CPP_EXTERN_C String_t* _stringLiteral31C244D856B46A8D9797F64184021411F8D1A054;
IL2CPP_EXTERN_C String_t* _stringLiteral3AF0D3E9771A3768C7B73D9BC5347F23791C861D;
IL2CPP_EXTERN_C String_t* _stringLiteral3CAE8FFCB80F093CACA64555228254ABA8C246B9;
IL2CPP_EXTERN_C String_t* _stringLiteral518B3D08731FC4B4ACDD4C12E1B1B37CC0E64603;
IL2CPP_EXTERN_C String_t* _stringLiteral5FA39088E79DEB93386A8A29EBFC4BF667035C7F;
IL2CPP_EXTERN_C String_t* _stringLiteral64727BD135950E8FFCB476F66EAA1B0747F2F8BC;
IL2CPP_EXTERN_C String_t* _stringLiteral6554658F724E1C1E95CF47B2EB6FBB96835C19D6;
IL2CPP_EXTERN_C String_t* _stringLiteralA1ECCC24C90A5178FA10A29190315449D65E6FA6;
IL2CPP_EXTERN_C String_t* _stringLiteralA7AB925FF80AE6B8E928777122DF6848168541DC;
IL2CPP_EXTERN_C String_t* _stringLiteralE8A96C404AB746F16F0578617B5A0B2B1011BF64;
IL2CPP_EXTERN_C String_t* _stringLiteralEA3408619B25F828989F9D14D19C43095B82B903;
IL2CPP_EXTERN_C const RuntimeMethod* AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AudioClip_SetData_m7B400A0E491EDFE98D3A732D189443846E74CD6C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C_0_0_0_var;
IL2CPP_EXTERN_C const uint32_t AudioClipPlayable_Equals_mEB47B5F2E1C643D403FA916C8961F117593DCFC0_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_GetData_m8150E67D6068CAA88BE4155CB5924B2359272EE0_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_SetData_m7B400A0E491EDFE98D3A732D189443846E74CD6C_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip__ctor_m52425138C3A036FC847A0E4C4ADA31CEF81CD10D_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_add_m_PCMReaderCallback_mE70789B25C74C552769FB2DAB96FC416A8508C62_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_add_m_PCMSetPositionCallback_mC0EBAE94510712D3E1481ED8B3FB7956169754F5_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_remove_m_PCMReaderCallback_m0AEFEC9C086DEBABE06F1294AFE0B4031D805FE7_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioClip_remove_m_PCMSetPositionCallback_m21FB4ECFD0CE6C754C5D3BBFDCE9AD21E6D074A2_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioConfigurationChangeHandler_BeginInvoke_mB0B0ACF6281B999FA11037CA130CA3C72BEC7827_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioMixerGroup__ctor_mCE836CE43DAF42CC9F5A83E92E3965D22C2119A4_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioMixerPlayable_Equals_m6B84D1A5AEDEAAE12AEFB77319B2662506ABC9C4_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSettings_InvokeOnAudioConfigurationChanged_m8D251791C6A402B12E93C22F43475DE3033FC8E7_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_GetOutputData_m0F928FDD4525BCC40ABE7D4B3CE93E505E604409_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_GetSpectrumData_m58D07A34603F25DD1A648EE8BFE55D9F1A6C0C25_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_PlayClipAtPoint_m484E3DF855E6D40448E5AAED9D77846617B8C0CE_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_PlayOneShot_mA65B809A4480039CD8337ABF45C0E57E137EED41_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_get_maxVolume_m062A75A13F618E5614614AA0E7801996D311988D_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_get_minVolume_m8A959E5FE81FEBEEA09C6A693AC753E030B3BD2A_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_get_rolloffFactor_mB207AAF2085DE7C1DE380A9A8FB825E78303E753_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_set_maxVolume_m4536FB7CBB5A2B8CA1EE64D97FECD241569634F1_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_set_minVolume_mC541C9D353B51A55845840038EC13A48B2361523_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t AudioSource_set_rolloffFactor_m357716D5400492671031FB94EB39AAB4569AF24C_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t PCMSetPositionCallback_BeginInvoke_m88CDF70D75854621CA69ED3D53CD53B8206A5093_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t SampleFramesHandler_BeginInvoke_mE516B77CCC50738663D10DDD2D7BDB4391FDFF92_MetadataUsageId;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;
struct SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct  U3CModuleU3E_t2E16431D825A5D233BFED659B3C516DAB0AC0286 
{
public:

public:
};


// System.Object

struct Il2CppArrayBounds;

// System.Array


// System.Reflection.MemberInfo
struct  MemberInfo_t  : public RuntimeObject
{
public:

public:
};


// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};

// UnityEngine.AudioSettings
struct  AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31  : public RuntimeObject
{
public:

public:
};

struct AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_StaticFields
{
public:
	// UnityEngine.AudioSettings_AudioConfigurationChangeHandler UnityEngine.AudioSettings::OnAudioConfigurationChanged
	AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * ___OnAudioConfigurationChanged_0;

public:
	inline static int32_t get_offset_of_OnAudioConfigurationChanged_0() { return static_cast<int32_t>(offsetof(AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_StaticFields, ___OnAudioConfigurationChanged_0)); }
	inline AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * get_OnAudioConfigurationChanged_0() const { return ___OnAudioConfigurationChanged_0; }
	inline AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 ** get_address_of_OnAudioConfigurationChanged_0() { return &___OnAudioConfigurationChanged_0; }
	inline void set_OnAudioConfigurationChanged_0(AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * value)
	{
		___OnAudioConfigurationChanged_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnAudioConfigurationChanged_0), (void*)value);
	}
};


// UnityEngine.Experimental.Audio.AudioSampleProvider
struct  AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913  : public RuntimeObject
{
public:
	// UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler UnityEngine.Experimental.Audio.AudioSampleProvider::sampleFramesAvailable
	SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * ___sampleFramesAvailable_0;
	// UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler UnityEngine.Experimental.Audio.AudioSampleProvider::sampleFramesOverflow
	SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * ___sampleFramesOverflow_1;

public:
	inline static int32_t get_offset_of_sampleFramesAvailable_0() { return static_cast<int32_t>(offsetof(AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913, ___sampleFramesAvailable_0)); }
	inline SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * get_sampleFramesAvailable_0() const { return ___sampleFramesAvailable_0; }
	inline SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF ** get_address_of_sampleFramesAvailable_0() { return &___sampleFramesAvailable_0; }
	inline void set_sampleFramesAvailable_0(SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * value)
	{
		___sampleFramesAvailable_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___sampleFramesAvailable_0), (void*)value);
	}

	inline static int32_t get_offset_of_sampleFramesOverflow_1() { return static_cast<int32_t>(offsetof(AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913, ___sampleFramesOverflow_1)); }
	inline SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * get_sampleFramesOverflow_1() const { return ___sampleFramesOverflow_1; }
	inline SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF ** get_address_of_sampleFramesOverflow_1() { return &___sampleFramesOverflow_1; }
	inline void set_sampleFramesOverflow_1(SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * value)
	{
		___sampleFramesOverflow_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___sampleFramesOverflow_1), (void*)value);
	}
};


// System.Boolean
struct  Boolean_tB53F6830F670160873277339AA58F15CAED4399C 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Double
struct  Double_t358B8F23BDC52A5DD700E727E204F9F7CDE12409 
{
public:
	// System.Double System.Double::m_value
	double ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Double_t358B8F23BDC52A5DD700E727E204F9F7CDE12409, ___m_value_0)); }
	inline double get_m_value_0() const { return ___m_value_0; }
	inline double* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(double value)
	{
		___m_value_0 = value;
	}
};

struct Double_t358B8F23BDC52A5DD700E727E204F9F7CDE12409_StaticFields
{
public:
	// System.Double System.Double::NegativeZero
	double ___NegativeZero_7;

public:
	inline static int32_t get_offset_of_NegativeZero_7() { return static_cast<int32_t>(offsetof(Double_t358B8F23BDC52A5DD700E727E204F9F7CDE12409_StaticFields, ___NegativeZero_7)); }
	inline double get_NegativeZero_7() const { return ___NegativeZero_7; }
	inline double* get_address_of_NegativeZero_7() { return &___NegativeZero_7; }
	inline void set_NegativeZero_7(double value)
	{
		___NegativeZero_7 = value;
	}
};


// System.Enum
struct  Enum_t2AF27C02B8653AE29442467390005ABC74D8F521  : public ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF
{
public:

public:
};

struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_com
{
};

// System.Int32
struct  Int32_t585191389E07734F19F3156FF88FB3EF4800D102 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_t585191389E07734F19F3156FF88FB3EF4800D102, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Single
struct  Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// System.UInt32
struct  UInt32_t4980FA09003AFAAB5A6E361BA2748EA9A005709B 
{
public:
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt32_t4980FA09003AFAAB5A6E361BA2748EA9A005709B, ___m_value_0)); }
	inline uint32_t get_m_value_0() const { return ___m_value_0; }
	inline uint32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint32_t value)
	{
		___m_value_0 = value;
	}
};


// System.UInt64
struct  UInt64_tA02DF3B59C8FC4A849BD207DA11038CC64E4CB4E 
{
public:
	// System.UInt64 System.UInt64::m_value
	uint64_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt64_tA02DF3B59C8FC4A849BD207DA11038CC64E4CB4E, ___m_value_0)); }
	inline uint64_t get_m_value_0() const { return ___m_value_0; }
	inline uint64_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint64_t value)
	{
		___m_value_0 = value;
	}
};


// System.Void
struct  Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017__padding[1];
	};

public:
};


// UnityEngine.Vector3
struct  Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___zeroVector_5)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___oneVector_6)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___upVector_7)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___downVector_8)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___leftVector_9)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___rightVector_10)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___forwardVector_11)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___backVector_12)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___negativeInfinityVector_14 = value;
	}
};


// System.Delegate
struct  Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_target_2), (void*)value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_info_7), (void*)value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___original_method_info_8), (void*)value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * get_data_9() const { return ___data_9; }
	inline DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_9), (void*)value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	int32_t ___method_is_virtual_10;
};

// System.Exception
struct  Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____className_1), (void*)value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_2), (void*)value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____data_3), (void*)value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerException_4), (void*)value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____helpURL_5), (void*)value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTrace_6), (void*)value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTraceString_7), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____remoteStackTraceString_8), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dynamicMethods_10), (void*)value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_12), (void*)value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____safeSerializationManager_13), (void*)value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___captured_traces_14), (void*)value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_trace_ips_15), (void*)value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_EDILock_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};

// System.Reflection.BindingFlags
struct  BindingFlags_tE35C91D046E63A1B92BB9AB909FCF9DA84379ED0 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(BindingFlags_tE35C91D046E63A1B92BB9AB909FCF9DA84379ED0, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.RuntimeTypeHandle
struct  RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};


// UnityEngine.AnimationCurve
struct  AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.AnimationCurve::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// UnityEngine.AudioClipLoadType
struct  AudioClipLoadType_t450FDA2569271A708F0562D58043E913C398B4EB 
{
public:
	// System.Int32 UnityEngine.AudioClipLoadType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AudioClipLoadType_t450FDA2569271A708F0562D58043E913C398B4EB, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AudioDataLoadState
struct  AudioDataLoadState_t73E86FB39C3CACACDD9EED288BD0BF137F4DE9DA 
{
public:
	// System.Int32 UnityEngine.AudioDataLoadState::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AudioDataLoadState_t73E86FB39C3CACACDD9EED288BD0BF137F4DE9DA, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AudioRolloffMode
struct  AudioRolloffMode_t6E80F49565F8A29A85F0EE610614DACE40BEDA61 
{
public:
	// System.Int32 UnityEngine.AudioRolloffMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AudioRolloffMode_t6E80F49565F8A29A85F0EE610614DACE40BEDA61, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AudioSourceCurveType
struct  AudioSourceCurveType_t9869DE8A93E82D13B5915B0476EB27E275F907B5 
{
public:
	// System.Int32 UnityEngine.AudioSourceCurveType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AudioSourceCurveType_t9869DE8A93E82D13B5915B0476EB27E275F907B5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AudioVelocityUpdateMode
struct  AudioVelocityUpdateMode_tF52F7FE5DBB4B462A81C4DB430724EAC3540E624 
{
public:
	// System.Int32 UnityEngine.AudioVelocityUpdateMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AudioVelocityUpdateMode_tF52F7FE5DBB4B462A81C4DB430724EAC3540E624, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.FFTWindow
struct  FFTWindow_t6897F3BD1458FB66ADF3C1EA8E1274414AE7C643 
{
public:
	// System.Int32 UnityEngine.FFTWindow::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FFTWindow_t6897F3BD1458FB66ADF3C1EA8E1274414AE7C643, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Object
struct  Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Playables.PlayableHandle
struct  PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182 
{
public:
	// System.IntPtr UnityEngine.Playables.PlayableHandle::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableHandle::m_Version
	uint32_t ___m_Version_1;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182, ___m_Handle_0)); }
	inline intptr_t get_m_Handle_0() const { return ___m_Handle_0; }
	inline intptr_t* get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(intptr_t value)
	{
		___m_Handle_0 = value;
	}

	inline static int32_t get_offset_of_m_Version_1() { return static_cast<int32_t>(offsetof(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182, ___m_Version_1)); }
	inline uint32_t get_m_Version_1() const { return ___m_Version_1; }
	inline uint32_t* get_address_of_m_Version_1() { return &___m_Version_1; }
	inline void set_m_Version_1(uint32_t value)
	{
		___m_Version_1 = value;
	}
};

struct PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182_StaticFields
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.PlayableHandle::m_Null
	PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  ___m_Null_2;

public:
	inline static int32_t get_offset_of_m_Null_2() { return static_cast<int32_t>(offsetof(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182_StaticFields, ___m_Null_2)); }
	inline PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  get_m_Null_2() const { return ___m_Null_2; }
	inline PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182 * get_address_of_m_Null_2() { return &___m_Null_2; }
	inline void set_m_Null_2(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  value)
	{
		___m_Null_2 = value;
	}
};


// UnityEngine.Playables.PlayableOutputHandle
struct  PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922 
{
public:
	// System.IntPtr UnityEngine.Playables.PlayableOutputHandle::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableOutputHandle::m_Version
	uint32_t ___m_Version_1;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922, ___m_Handle_0)); }
	inline intptr_t get_m_Handle_0() const { return ___m_Handle_0; }
	inline intptr_t* get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(intptr_t value)
	{
		___m_Handle_0 = value;
	}

	inline static int32_t get_offset_of_m_Version_1() { return static_cast<int32_t>(offsetof(PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922, ___m_Version_1)); }
	inline uint32_t get_m_Version_1() const { return ___m_Version_1; }
	inline uint32_t* get_address_of_m_Version_1() { return &___m_Version_1; }
	inline void set_m_Version_1(uint32_t value)
	{
		___m_Version_1 = value;
	}
};

struct PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922_StaticFields
{
public:
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutputHandle::m_Null
	PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922  ___m_Null_2;

public:
	inline static int32_t get_offset_of_m_Null_2() { return static_cast<int32_t>(offsetof(PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922_StaticFields, ___m_Null_2)); }
	inline PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922  get_m_Null_2() const { return ___m_Null_2; }
	inline PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922 * get_address_of_m_Null_2() { return &___m_Null_2; }
	inline void set_m_Null_2(PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922  value)
	{
		___m_Null_2 = value;
	}
};


// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_11), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};

// System.SystemException
struct  SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782  : public Exception_t
{
public:

public:
};


// System.Type
struct  Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  ____impl_9;

public:
	inline static int32_t get_offset_of__impl_9() { return static_cast<int32_t>(offsetof(Type_t, ____impl_9)); }
	inline RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  get__impl_9() const { return ____impl_9; }
	inline RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D * get_address_of__impl_9() { return &____impl_9; }
	inline void set__impl_9(RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  value)
	{
		____impl_9 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * ___FilterAttribute_0;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * ___FilterName_1;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * ___FilterNameIgnoreCase_2;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_3;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_4;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* ___EmptyTypes_5;
	// System.Reflection.Binder System.Type::defaultBinder
	Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 * ___defaultBinder_6;

public:
	inline static int32_t get_offset_of_FilterAttribute_0() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_0)); }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * get_FilterAttribute_0() const { return ___FilterAttribute_0; }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 ** get_address_of_FilterAttribute_0() { return &___FilterAttribute_0; }
	inline void set_FilterAttribute_0(MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * value)
	{
		___FilterAttribute_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterAttribute_0), (void*)value);
	}

	inline static int32_t get_offset_of_FilterName_1() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_1)); }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * get_FilterName_1() const { return ___FilterName_1; }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 ** get_address_of_FilterName_1() { return &___FilterName_1; }
	inline void set_FilterName_1(MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * value)
	{
		___FilterName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterName_1), (void*)value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_2)); }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * get_FilterNameIgnoreCase_2() const { return ___FilterNameIgnoreCase_2; }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 ** get_address_of_FilterNameIgnoreCase_2() { return &___FilterNameIgnoreCase_2; }
	inline void set_FilterNameIgnoreCase_2(MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * value)
	{
		___FilterNameIgnoreCase_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterNameIgnoreCase_2), (void*)value);
	}

	inline static int32_t get_offset_of_Missing_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_3)); }
	inline RuntimeObject * get_Missing_3() const { return ___Missing_3; }
	inline RuntimeObject ** get_address_of_Missing_3() { return &___Missing_3; }
	inline void set_Missing_3(RuntimeObject * value)
	{
		___Missing_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Missing_3), (void*)value);
	}

	inline static int32_t get_offset_of_Delimiter_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_4)); }
	inline Il2CppChar get_Delimiter_4() const { return ___Delimiter_4; }
	inline Il2CppChar* get_address_of_Delimiter_4() { return &___Delimiter_4; }
	inline void set_Delimiter_4(Il2CppChar value)
	{
		___Delimiter_4 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_5)); }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* get_EmptyTypes_5() const { return ___EmptyTypes_5; }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F** get_address_of_EmptyTypes_5() { return &___EmptyTypes_5; }
	inline void set_EmptyTypes_5(TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* value)
	{
		___EmptyTypes_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___EmptyTypes_5), (void*)value);
	}

	inline static int32_t get_offset_of_defaultBinder_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___defaultBinder_6)); }
	inline Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 * get_defaultBinder_6() const { return ___defaultBinder_6; }
	inline Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 ** get_address_of_defaultBinder_6() { return &___defaultBinder_6; }
	inline void set_defaultBinder_6(Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 * value)
	{
		___defaultBinder_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultBinder_6), (void*)value);
	}
};


// UnityEngine.Audio.AudioClipPlayable
struct  AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Audio.AudioClipPlayable::m_Handle
	PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C, ___m_Handle_0)); }
	inline PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182 * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  value)
	{
		___m_Handle_0 = value;
	}
};


// UnityEngine.Audio.AudioMixerGroup
struct  AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// UnityEngine.Audio.AudioMixerPlayable
struct  AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Audio.AudioMixerPlayable::m_Handle
	PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F, ___m_Handle_0)); }
	inline PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182 * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  value)
	{
		___m_Handle_0 = value;
	}
};


// UnityEngine.Audio.AudioPlayableOutput
struct  AudioPlayableOutput_tD2671908FEE2832112E8A3B611089A2558A4DA6B 
{
public:
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Audio.AudioPlayableOutput::m_Handle
	PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AudioPlayableOutput_tD2671908FEE2832112E8A3B611089A2558A4DA6B, ___m_Handle_0)); }
	inline PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922 * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableOutputHandle_t0D0C9D8ACC1A4061BD4EAEB61F3EE0357052F922  value)
	{
		___m_Handle_0 = value;
	}
};


// UnityEngine.AudioClip
struct  AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:
	// UnityEngine.AudioClip_PCMReaderCallback UnityEngine.AudioClip::m_PCMReaderCallback
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___m_PCMReaderCallback_4;
	// UnityEngine.AudioClip_PCMSetPositionCallback UnityEngine.AudioClip::m_PCMSetPositionCallback
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___m_PCMSetPositionCallback_5;

public:
	inline static int32_t get_offset_of_m_PCMReaderCallback_4() { return static_cast<int32_t>(offsetof(AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051, ___m_PCMReaderCallback_4)); }
	inline PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * get_m_PCMReaderCallback_4() const { return ___m_PCMReaderCallback_4; }
	inline PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB ** get_address_of_m_PCMReaderCallback_4() { return &___m_PCMReaderCallback_4; }
	inline void set_m_PCMReaderCallback_4(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * value)
	{
		___m_PCMReaderCallback_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_PCMReaderCallback_4), (void*)value);
	}

	inline static int32_t get_offset_of_m_PCMSetPositionCallback_5() { return static_cast<int32_t>(offsetof(AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051, ___m_PCMSetPositionCallback_5)); }
	inline PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * get_m_PCMSetPositionCallback_5() const { return ___m_PCMSetPositionCallback_5; }
	inline PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 ** get_address_of_m_PCMSetPositionCallback_5() { return &___m_PCMSetPositionCallback_5; }
	inline void set_m_PCMSetPositionCallback_5(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * value)
	{
		___m_PCMSetPositionCallback_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_PCMSetPositionCallback_5), (void*)value);
	}
};


// UnityEngine.Component
struct  Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// UnityEngine.GameObject
struct  GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// System.ArgumentException
struct  ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1  : public SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782
{
public:
	// System.String System.ArgumentException::m_paramName
	String_t* ___m_paramName_17;

public:
	inline static int32_t get_offset_of_m_paramName_17() { return static_cast<int32_t>(offsetof(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1, ___m_paramName_17)); }
	inline String_t* get_m_paramName_17() const { return ___m_paramName_17; }
	inline String_t** get_address_of_m_paramName_17() { return &___m_paramName_17; }
	inline void set_m_paramName_17(String_t* value)
	{
		___m_paramName_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_paramName_17), (void*)value);
	}
};


// System.AsyncCallback
struct  AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4  : public MulticastDelegate_t
{
public:

public:
};


// System.NullReferenceException
struct  NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC  : public SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782
{
public:

public:
};


// UnityEngine.AudioClip_PCMReaderCallback
struct  PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.AudioClip_PCMSetPositionCallback
struct  PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.AudioSettings_AudioConfigurationChangeHandler
struct  AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Behaviour
struct  Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};


// UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler
struct  SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Transform
struct  Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};


// UnityEngine.AudioBehaviour
struct  AudioBehaviour_tC612EC4E17A648A5C568621F3FBF1DBD773C71C7  : public Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8
{
public:

public:
};


// UnityEngine.AudioListener
struct  AudioListener_tE3E1467B84A4AFD509947B44A7C8ACFB67FF2099  : public AudioBehaviour_tC612EC4E17A648A5C568621F3FBF1DBD773C71C7
{
public:

public:
};


// UnityEngine.AudioSource
struct  AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C  : public AudioBehaviour_tC612EC4E17A648A5C568621F3FBF1DBD773C71C7
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Single[]
struct SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) float m_Items[1];

public:
	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Delegate_t * m_Items[1];

public:
	inline Delegate_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};



// UnityEngine.Playables.PlayableHandle UnityEngine.Audio.AudioClipPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  AudioClipPlayable_GetHandle_mEE8F62E9DA2A0DDDB064A9AA2391909C425CB3B1 (AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::op_Equality(UnityEngine.Playables.PlayableHandle,UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_op_Equality_mBA774AE123AF794A1EB55148206CDD52DAFA42DF (PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  ___x0, PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  ___y1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Audio.AudioClipPlayable::Equals(UnityEngine.Audio.AudioClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClipPlayable_Equals_mEB47B5F2E1C643D403FA916C8961F117593DCFC0 (AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C * __this, AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C  ___other0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m091EBAEBC7919B0391ABDAFB7389ADC12206525B (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * __this, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Audio.AudioMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  AudioMixerPlayable_GetHandle_mDBC7135DF653E0E19675B6694EA89958E609587D (AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Audio.AudioMixerPlayable::Equals(UnityEngine.Audio.AudioMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioMixerPlayable_Equals_m6B84D1A5AEDEAAE12AEFB77319B2662506ABC9C4 (AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F * __this, AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F  ___other0, const RuntimeMethod* method);
// System.Void UnityEngine.Behaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Behaviour__ctor_m409AEC21511ACF9A4CC0654DF4B8253E0D81D22C (Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.AudioClip::get_channels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method);
// System.String UnityEngine.AudioClip::GetName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mF4626905368D6558695A823466A1AF65EADB9923 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m4B7C70BAFD477C6BDB59C88A0934F0B018D03708 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Boolean UnityEngine.AudioClip::GetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_GetData_mEF59EDCD10F83C280DB82E14FF938FF574BBD128 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data1, int32_t ___numSamples2, int32_t ___samplesOffset3, const RuntimeMethod* method);
// System.Int32 UnityEngine.AudioClip::get_samples()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_samples_m7AD532D9288680102A452D2949107BDA88268CA0 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method);
// System.Void System.ArgumentException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7 (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Boolean UnityEngine.AudioClip::SetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_SetData_m9422A5FB335AFB42C2CBAD4EE650C5F71ECB3559 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data1, int32_t ___numsamples2, int32_t ___samplesOffset3, const RuntimeMethod* method);
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m76744E6CF5A521F79D0282A6FBEAAC37FE9C0BF5 (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, const RuntimeMethod* method);
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean,UnityEngine.AudioClip/PCMReaderCallback,UnityEngine.AudioClip/PCMSetPositionCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995 (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___pcmreadercallback5, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___pcmsetpositioncallback6, const RuntimeMethod* method);
// System.Void System.NullReferenceException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NullReferenceException__ctor_m7D46E331C349DD29CBA488C9B6A950A3E7DD5CAE (NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC * __this, const RuntimeMethod* method);
// UnityEngine.AudioClip UnityEngine.AudioClip::Construct_Internal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Construct_Internal_mEEA2165F0467FA67FA05361A85434DF5068E79B0 (const RuntimeMethod* method);
// System.Void UnityEngine.AudioClip::add_m_PCMReaderCallback(UnityEngine.AudioClip/PCMReaderCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_add_m_PCMReaderCallback_mE70789B25C74C552769FB2DAB96FC416A8508C62 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioClip::add_m_PCMSetPositionCallback(UnityEngine.AudioClip/PCMSetPositionCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_add_m_PCMSetPositionCallback_mC0EBAE94510712D3E1481ED8B3FB7956169754F5 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioClip::CreateUserSound(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_CreateUserSound_m56B1F9909AB1F6CABCA8C526657F99A8BC0E73BD (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, const RuntimeMethod* method);
// System.Delegate System.Delegate::Combine(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t * Delegate_Combine_mC25D2F7DECAFBA6D9A2F9EBA8A77063F0658ECF1 (Delegate_t * ___a0, Delegate_t * ___b1, const RuntimeMethod* method);
// System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t * Delegate_Remove_m0B0DB7D1B3AF96B71AFAA72BA0EFE32FBBC2932D (Delegate_t * ___source0, Delegate_t * ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.AudioClip/PCMReaderCallback::Invoke(System.Single[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMReaderCallback_Invoke_m7B101820DB35BEFC8D2724DF96900367863B93B6 (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioClip/PCMSetPositionCallback::Invoke(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMSetPositionCallback_Invoke_m8EA4736B43191A8E6F95E1548AFF124519EC533C (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * __this, int32_t ___position0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSettings/AudioConfigurationChangeHandler::Invoke(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioConfigurationChangeHandler_Invoke_m62D72B397E1DC117C8C92A450D2C86C535A2BF49 (AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * __this, bool ___deviceWasChanged0, const RuntimeMethod* method);
// System.Single UnityEngine.AudioSource::GetPitch(UnityEngine.AudioSource)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_GetPitch_m76B68079F309EB1FE2BFF4A0B014B89780B383CA (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::SetPitch(UnityEngine.AudioSource,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetPitch_mB65EF59C56A49FD68CD3361B2C34E07F89F1244B (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, float ___pitch1, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::PlayHelper(UnityEngine.AudioSource,System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, uint64_t ___delay1, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::Play(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, double ___delay0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::PlayOneShot(UnityEngine.AudioClip,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayOneShot_mA65B809A4480039CD8337ABF45C0E57E137EED41 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, float ___volumeScale1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mBC2401774F3BE33E8CF6F0A8148E66C95D6CFF1C (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * ___x0, Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * ___y1, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m37338644DC81F640CCDFEAE35A223F0E965F0568 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::PlayOneShotHelper(UnityEngine.AudioSource,UnityEngine.AudioClip,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayOneShotHelper_mDAEDF5E0C56C665DE62CDF26E7B98149B4A71704 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip1, float ___volumeScale2, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::Stop(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Stop_mD3712B98BC6DBEA9CEEF778CE9CCB8DBA62F47A8 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___stopOneShots0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::PlayClipAtPoint(UnityEngine.AudioClip,UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayClipAtPoint_m484E3DF855E6D40448E5AAED9D77846617B8C0CE (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___position1, float ___volume2, const RuntimeMethod* method);
// System.Void UnityEngine.GameObject::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject__ctor_mBB454E679AD9CF0B84D3609A01E6A9753ACF4686 (GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * __this, String_t* ___name0, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * GameObject_get_transform_mA5C38857137F137CB96C69FAA624199EB1C2FB2C (GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mDA89E4893F14ECA5CBEEE7FB80A5BF7C1B8EA6DC (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value0, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6 (RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  ___handle0, const RuntimeMethod* method);
// UnityEngine.Component UnityEngine.GameObject::AddComponent(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621 * GameObject_AddComponent_m489C9D5426F2050795FA696CD478BB49AAE4BD70 (GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * __this, Type_t * ___componentType0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::set_clip(UnityEngine.AudioClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_clip_mF574231E0B749E0167CAF9E4FCBA06BAA0F9ED9B (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::set_spatialBlend(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spatialBlend_mC144B8230F08743505D4B0A92C1B9F809BC6D9C5 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::set_volume(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_volume_mF1757D70EE113871724334D13F70EF1ED033BA06 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::Play()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Play_m0BA206481892AA4AF7DB2900A0B0805076516164 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method);
// System.Single UnityEngine.AudioClip::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioClip_get_length_mFF1E21363B1860453451C4DA1C1459E9B9504317 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_timeScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_timeScale_m7E198A5814859A08FD0FFE6DD5F7ED5C907719F8 (const RuntimeMethod* method);
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_m09F51D8BDECFD2E8C618498EF7377029B669030D (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * ___obj0, float ___t1, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::SetCustomCurveHelper(UnityEngine.AudioSource,UnityEngine.AudioSourceCurveType,UnityEngine.AnimationCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetCustomCurveHelper_mB444ACB3E7BF771A4E724310A44669D5F1236C23 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, int32_t ___type1, AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * ___curve2, const RuntimeMethod* method);
// UnityEngine.AnimationCurve UnityEngine.AudioSource::GetCustomCurveHelper(UnityEngine.AudioSource,UnityEngine.AudioSourceCurveType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * AudioSource_GetCustomCurveHelper_m0D5A8403CAC89257DF8ACD15C514A5DE621BF749 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, int32_t ___type1, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::GetOutputDataHelper(UnityEngine.AudioSource,System.Single[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___samples1, int32_t ___channel2, const RuntimeMethod* method);
// System.Void UnityEngine.AudioSource::GetSpectrumDataHelper(UnityEngine.AudioSource,System.Single[],System.Int32,UnityEngine.FFTWindow)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___samples1, int32_t ___channel2, int32_t ___window3, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.AudioBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioBehaviour__ctor_m43B1C08196D937549E20DE6370263646C1D81F59 (AudioBehaviour_tC612EC4E17A648A5C568621F3FBF1DBD773C71C7 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.Audio.AudioSampleProvider/SampleFramesHandler::Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleFramesHandler_Invoke_m52F0148F680B36E04A7F850E617FBEF1CA9809FD (SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * __this, AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 * ___provider0, uint32_t ___sampleFrameCount1, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Playables.PlayableHandle UnityEngine.Audio.AudioClipPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  AudioClipPlayable_GetHandle_mEE8F62E9DA2A0DDDB064A9AA2391909C425CB3B1 (AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C * __this, const RuntimeMethod* method)
{
	PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  AudioClipPlayable_GetHandle_mEE8F62E9DA2A0DDDB064A9AA2391909C425CB3B1_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C * _thisAdjusted = reinterpret_cast<AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C *>(__this + _offset);
	return AudioClipPlayable_GetHandle_mEE8F62E9DA2A0DDDB064A9AA2391909C425CB3B1(_thisAdjusted, method);
}
// System.Boolean UnityEngine.Audio.AudioClipPlayable::Equals(UnityEngine.Audio.AudioClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClipPlayable_Equals_mEB47B5F2E1C643D403FA916C8961F117593DCFC0 (AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C * __this, AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClipPlayable_Equals_mEB47B5F2E1C643D403FA916C8961F117593DCFC0_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_0 = AudioClipPlayable_GetHandle_mEE8F62E9DA2A0DDDB064A9AA2391909C425CB3B1((AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C *)__this, /*hidden argument*/NULL);
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_1 = AudioClipPlayable_GetHandle_mEE8F62E9DA2A0DDDB064A9AA2391909C425CB3B1((AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182_il2cpp_TypeInfo_var);
		bool L_2 = PlayableHandle_op_Equality_mBA774AE123AF794A1EB55148206CDD52DAFA42DF(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AudioClipPlayable_Equals_mEB47B5F2E1C643D403FA916C8961F117593DCFC0_AdjustorThunk (RuntimeObject * __this, AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C * _thisAdjusted = reinterpret_cast<AudioClipPlayable_t6094311F945E65BC29F85B23A81E8426D596553C *>(__this + _offset);
	return AudioClipPlayable_Equals_mEB47B5F2E1C643D403FA916C8961F117593DCFC0(_thisAdjusted, ___other0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Audio.AudioMixerGroup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioMixerGroup__ctor_mCE836CE43DAF42CC9F5A83E92E3965D22C2119A4 (AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioMixerGroup__ctor_mCE836CE43DAF42CC9F5A83E92E3965D22C2119A4_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		Object__ctor_m091EBAEBC7919B0391ABDAFB7389ADC12206525B(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Playables.PlayableHandle UnityEngine.Audio.AudioMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  AudioMixerPlayable_GetHandle_mDBC7135DF653E0E19675B6694EA89958E609587D (AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F * __this, const RuntimeMethod* method)
{
	PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  AudioMixerPlayable_GetHandle_mDBC7135DF653E0E19675B6694EA89958E609587D_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F * _thisAdjusted = reinterpret_cast<AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F *>(__this + _offset);
	return AudioMixerPlayable_GetHandle_mDBC7135DF653E0E19675B6694EA89958E609587D(_thisAdjusted, method);
}
// System.Boolean UnityEngine.Audio.AudioMixerPlayable::Equals(UnityEngine.Audio.AudioMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioMixerPlayable_Equals_m6B84D1A5AEDEAAE12AEFB77319B2662506ABC9C4 (AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F * __this, AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioMixerPlayable_Equals_m6B84D1A5AEDEAAE12AEFB77319B2662506ABC9C4_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_0 = AudioMixerPlayable_GetHandle_mDBC7135DF653E0E19675B6694EA89958E609587D((AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F *)__this, /*hidden argument*/NULL);
		PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182  L_1 = AudioMixerPlayable_GetHandle_mDBC7135DF653E0E19675B6694EA89958E609587D((AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t9D3B4E540D4413CED81DDD6A24C5373BEFA1D182_il2cpp_TypeInfo_var);
		bool L_2 = PlayableHandle_op_Equality_mBA774AE123AF794A1EB55148206CDD52DAFA42DF(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AudioMixerPlayable_Equals_m6B84D1A5AEDEAAE12AEFB77319B2662506ABC9C4_AdjustorThunk (RuntimeObject * __this, AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F * _thisAdjusted = reinterpret_cast<AudioMixerPlayable_t2C445EB39F9111CCFF7E2E1F813B22007862FA9F *>(__this + _offset);
	return AudioMixerPlayable_Equals_m6B84D1A5AEDEAAE12AEFB77319B2662506ABC9C4(_thisAdjusted, ___other0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AudioBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioBehaviour__ctor_m43B1C08196D937549E20DE6370263646C1D81F59 (AudioBehaviour_tC612EC4E17A648A5C568621F3FBF1DBD773C71C7 * __this, const RuntimeMethod* method)
{
	{
		Behaviour__ctor_m409AEC21511ACF9A4CC0654DF4B8253E0D81D22C(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AudioClip::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip__ctor_m52425138C3A036FC847A0E4C4ADA31CEF81CD10D (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip__ctor_m52425138C3A036FC847A0E4C4ADA31CEF81CD10D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->set_m_PCMReaderCallback_4((PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)NULL);
		__this->set_m_PCMSetPositionCallback_5((PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		Object__ctor_m091EBAEBC7919B0391ABDAFB7389ADC12206525B(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.AudioClip::GetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_GetData_mEF59EDCD10F83C280DB82E14FF938FF574BBD128 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data1, int32_t ___numSamples2, int32_t ___samplesOffset3, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_GetData_mEF59EDCD10F83C280DB82E14FF938FF574BBD128_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, int32_t, int32_t);
	static AudioClip_GetData_mEF59EDCD10F83C280DB82E14FF938FF574BBD128_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_GetData_mEF59EDCD10F83C280DB82E14FF938FF574BBD128_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::GetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)");
	bool retVal = _il2cpp_icall_func(___clip0, ___data1, ___numSamples2, ___samplesOffset3);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::SetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_SetData_m9422A5FB335AFB42C2CBAD4EE650C5F71ECB3559 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data1, int32_t ___numsamples2, int32_t ___samplesOffset3, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_SetData_m9422A5FB335AFB42C2CBAD4EE650C5F71ECB3559_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, int32_t, int32_t);
	static AudioClip_SetData_m9422A5FB335AFB42C2CBAD4EE650C5F71ECB3559_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_SetData_m9422A5FB335AFB42C2CBAD4EE650C5F71ECB3559_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::SetData(UnityEngine.AudioClip,System.Single[],System.Int32,System.Int32)");
	bool retVal = _il2cpp_icall_func(___clip0, ___data1, ___numsamples2, ___samplesOffset3);
	return retVal;
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Construct_Internal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Construct_Internal_mEEA2165F0467FA67FA05361A85434DF5068E79B0 (const RuntimeMethod* method)
{
	typedef AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * (*AudioClip_Construct_Internal_mEEA2165F0467FA67FA05361A85434DF5068E79B0_ftn) ();
	static AudioClip_Construct_Internal_mEEA2165F0467FA67FA05361A85434DF5068E79B0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_Construct_Internal_mEEA2165F0467FA67FA05361A85434DF5068E79B0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::Construct_Internal()");
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * retVal = _il2cpp_icall_func();
	return retVal;
}
// System.String UnityEngine.AudioClip::GetName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef String_t* (*AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::GetName()");
	String_t* retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioClip::CreateUserSound(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_CreateUserSound_m56B1F9909AB1F6CABCA8C526657F99A8BC0E73BD (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, const RuntimeMethod* method)
{
	typedef void (*AudioClip_CreateUserSound_m56B1F9909AB1F6CABCA8C526657F99A8BC0E73BD_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *, String_t*, int32_t, int32_t, int32_t, bool);
	static AudioClip_CreateUserSound_m56B1F9909AB1F6CABCA8C526657F99A8BC0E73BD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_CreateUserSound_m56B1F9909AB1F6CABCA8C526657F99A8BC0E73BD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::CreateUserSound(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)");
	_il2cpp_icall_func(__this, ___name0, ___lengthSamples1, ___channels2, ___frequency3, ___stream4);
}
// System.Single UnityEngine.AudioClip::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioClip_get_length_mFF1E21363B1860453451C4DA1C1459E9B9504317 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef float (*AudioClip_get_length_mFF1E21363B1860453451C4DA1C1459E9B9504317_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_length_mFF1E21363B1860453451C4DA1C1459E9B9504317_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_length_mFF1E21363B1860453451C4DA1C1459E9B9504317_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_length()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Int32 UnityEngine.AudioClip::get_samples()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_samples_m7AD532D9288680102A452D2949107BDA88268CA0 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioClip_get_samples_m7AD532D9288680102A452D2949107BDA88268CA0_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_samples_m7AD532D9288680102A452D2949107BDA88268CA0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_samples_m7AD532D9288680102A452D2949107BDA88268CA0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_samples()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Int32 UnityEngine.AudioClip::get_channels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_channels()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Int32 UnityEngine.AudioClip::get_frequency()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_frequency_m8CE3C1898AEC71B496092039B233B61EED527661 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioClip_get_frequency_m8CE3C1898AEC71B496092039B233B61EED527661_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_frequency_m8CE3C1898AEC71B496092039B233B61EED527661_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_frequency_m8CE3C1898AEC71B496092039B233B61EED527661_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_frequency()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::get_isReadyToPlay()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_get_isReadyToPlay_m91F5912C95B6B20CC7BCC2F2D730C16B7218E7A6 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_get_isReadyToPlay_m91F5912C95B6B20CC7BCC2F2D730C16B7218E7A6_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_isReadyToPlay_m91F5912C95B6B20CC7BCC2F2D730C16B7218E7A6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_isReadyToPlay_m91F5912C95B6B20CC7BCC2F2D730C16B7218E7A6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_isReadyToPlay()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// UnityEngine.AudioClipLoadType UnityEngine.AudioClip::get_loadType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_loadType_mDFD0343749037166142BDAF8209136E82F8C9C39 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioClip_get_loadType_mDFD0343749037166142BDAF8209136E82F8C9C39_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_loadType_mDFD0343749037166142BDAF8209136E82F8C9C39_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_loadType_mDFD0343749037166142BDAF8209136E82F8C9C39_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_loadType()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::LoadAudioData()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_LoadAudioData_m9097E950A592C6EA563BC1BF31FF3C736AE1AD00 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_LoadAudioData_m9097E950A592C6EA563BC1BF31FF3C736AE1AD00_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_LoadAudioData_m9097E950A592C6EA563BC1BF31FF3C736AE1AD00_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_LoadAudioData_m9097E950A592C6EA563BC1BF31FF3C736AE1AD00_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::LoadAudioData()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::UnloadAudioData()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_UnloadAudioData_mE75A7CDF01DCF9905E285468DDEA7646623B084A (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_UnloadAudioData_mE75A7CDF01DCF9905E285468DDEA7646623B084A_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_UnloadAudioData_mE75A7CDF01DCF9905E285468DDEA7646623B084A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_UnloadAudioData_mE75A7CDF01DCF9905E285468DDEA7646623B084A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::UnloadAudioData()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::get_preloadAudioData()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_get_preloadAudioData_m31FB68C11E3C8B14D499E5F47A309F6917299034 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_get_preloadAudioData_m31FB68C11E3C8B14D499E5F47A309F6917299034_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_preloadAudioData_m31FB68C11E3C8B14D499E5F47A309F6917299034_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_preloadAudioData_m31FB68C11E3C8B14D499E5F47A309F6917299034_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_preloadAudioData()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::get_ambisonic()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_get_ambisonic_m9C97B0E60B6AD2A70849439DFCB08D3F3968A1A4 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_get_ambisonic_m9C97B0E60B6AD2A70849439DFCB08D3F3968A1A4_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_ambisonic_m9C97B0E60B6AD2A70849439DFCB08D3F3968A1A4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_ambisonic_m9C97B0E60B6AD2A70849439DFCB08D3F3968A1A4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_ambisonic()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::get_loadInBackground()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_get_loadInBackground_m35996031E6314129066B0EE33311AB8D934914DE (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioClip_get_loadInBackground_m35996031E6314129066B0EE33311AB8D934914DE_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_loadInBackground_m35996031E6314129066B0EE33311AB8D934914DE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_loadInBackground_m35996031E6314129066B0EE33311AB8D934914DE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_loadInBackground()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// UnityEngine.AudioDataLoadState UnityEngine.AudioClip::get_loadState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioClip_get_loadState_mD0CAA76E09B705ED1EBD7F576792A64AACE13BFD (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioClip_get_loadState_mD0CAA76E09B705ED1EBD7F576792A64AACE13BFD_ftn) (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioClip_get_loadState_mD0CAA76E09B705ED1EBD7F576792A64AACE13BFD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioClip_get_loadState_mD0CAA76E09B705ED1EBD7F576792A64AACE13BFD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioClip::get_loadState()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioClip::GetData(System.Single[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_GetData_m8150E67D6068CAA88BE4155CB5924B2359272EE0 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, int32_t ___offsetSamples1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_GetData_m8150E67D6068CAA88BE4155CB5924B2359272EE0_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	int32_t G_B5_0 = 0;
	{
		int32_t L_0 = AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)((((int32_t)L_0) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0031;
		}
	}
	{
		String_t* L_2 = AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257(__this, /*hidden argument*/NULL);
		String_t* L_3 = String_Concat_mF4626905368D6558695A823466A1AF65EADB9923(_stringLiteral6554658F724E1C1E95CF47B2EB6FBB96835C19D6, L_2, _stringLiteral5FA39088E79DEB93386A8A29EBFC4BF667035C7F, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_Log_m4B7C70BAFD477C6BDB59C88A0934F0B018D03708(L_3, /*hidden argument*/NULL);
		V_2 = (bool)0;
		goto IL_004e;
	}

IL_0031:
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_4 = ___data0;
		if (L_4)
		{
			goto IL_0037;
		}
	}
	{
		G_B5_0 = 0;
		goto IL_0041;
	}

IL_0037:
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_5 = ___data0;
		NullCheck(L_5);
		int32_t L_6 = AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC(__this, /*hidden argument*/NULL);
		G_B5_0 = ((int32_t)((int32_t)(((int32_t)((int32_t)(((RuntimeArray*)L_5)->max_length))))/(int32_t)L_6));
	}

IL_0041:
	{
		V_0 = G_B5_0;
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_7 = ___data0;
		int32_t L_8 = V_0;
		int32_t L_9 = ___offsetSamples1;
		bool L_10 = AudioClip_GetData_mEF59EDCD10F83C280DB82E14FF938FF574BBD128(__this, L_7, L_8, L_9, /*hidden argument*/NULL);
		V_2 = L_10;
		goto IL_004e;
	}

IL_004e:
	{
		bool L_11 = V_2;
		return L_11;
	}
}
// System.Boolean UnityEngine.AudioClip::SetData(System.Single[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioClip_SetData_m7B400A0E491EDFE98D3A732D189443846E74CD6C (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, int32_t ___offsetSamples1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_SetData_m7B400A0E491EDFE98D3A732D189443846E74CD6C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	int32_t G_B5_0 = 0;
	int32_t G_B10_0 = 0;
	{
		int32_t L_0 = AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)((((int32_t)L_0) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0031;
		}
	}
	{
		String_t* L_2 = AudioClip_GetName_mD69F28B33950F21E36A2F3A659DD89725796D257(__this, /*hidden argument*/NULL);
		String_t* L_3 = String_Concat_mF4626905368D6558695A823466A1AF65EADB9923(_stringLiteral518B3D08731FC4B4ACDD4C12E1B1B37CC0E64603, L_2, _stringLiteral5FA39088E79DEB93386A8A29EBFC4BF667035C7F, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_Log_m4B7C70BAFD477C6BDB59C88A0934F0B018D03708(L_3, /*hidden argument*/NULL);
		V_1 = (bool)0;
		goto IL_0082;
	}

IL_0031:
	{
		int32_t L_4 = ___offsetSamples1;
		if ((((int32_t)L_4) < ((int32_t)0)))
		{
			goto IL_0043;
		}
	}
	{
		int32_t L_5 = ___offsetSamples1;
		int32_t L_6 = AudioClip_get_samples_m7AD532D9288680102A452D2949107BDA88268CA0(__this, /*hidden argument*/NULL);
		G_B5_0 = ((((int32_t)((((int32_t)L_5) < ((int32_t)L_6))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0044;
	}

IL_0043:
	{
		G_B5_0 = 1;
	}

IL_0044:
	{
		V_2 = (bool)G_B5_0;
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_0053;
		}
	}
	{
		ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * L_8 = (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 *)il2cpp_codegen_object_new(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7(L_8, _stringLiteralA1ECCC24C90A5178FA10A29190315449D65E6FA6, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, AudioClip_SetData_m7B400A0E491EDFE98D3A732D189443846E74CD6C_RuntimeMethod_var);
	}

IL_0053:
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_9 = ___data0;
		if (!L_9)
		{
			goto IL_005d;
		}
	}
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_10 = ___data0;
		NullCheck(L_10);
		G_B10_0 = ((((int32_t)(((RuntimeArray*)L_10)->max_length)) == ((int32_t)0))? 1 : 0);
		goto IL_005e;
	}

IL_005d:
	{
		G_B10_0 = 1;
	}

IL_005e:
	{
		V_3 = (bool)G_B10_0;
		bool L_11 = V_3;
		if (!L_11)
		{
			goto IL_006d;
		}
	}
	{
		ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * L_12 = (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 *)il2cpp_codegen_object_new(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7(L_12, _stringLiteral64727BD135950E8FFCB476F66EAA1B0747F2F8BC, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_12, AudioClip_SetData_m7B400A0E491EDFE98D3A732D189443846E74CD6C_RuntimeMethod_var);
	}

IL_006d:
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_13 = ___data0;
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_14 = ___data0;
		NullCheck(L_14);
		int32_t L_15 = AudioClip_get_channels_m2CF01E121CEBBF3B69EC7EEE7EC28172AB6078EC(__this, /*hidden argument*/NULL);
		int32_t L_16 = ___offsetSamples1;
		bool L_17 = AudioClip_SetData_m9422A5FB335AFB42C2CBAD4EE650C5F71ECB3559(__this, L_13, ((int32_t)((int32_t)(((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length))))/(int32_t)L_15)), L_16, /*hidden argument*/NULL);
		V_1 = L_17;
		goto IL_0082;
	}

IL_0082:
	{
		bool L_18 = V_1;
		return L_18;
	}
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m5AC7FB41BB76CCDFB227C4EA07AD6158182B602B (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ____3D4, bool ___stream5, const RuntimeMethod* method)
{
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_0 = NULL;
	{
		String_t* L_0 = ___name0;
		int32_t L_1 = ___lengthSamples1;
		int32_t L_2 = ___channels2;
		int32_t L_3 = ___frequency3;
		bool L_4 = ___stream5;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_5 = AudioClip_Create_m76744E6CF5A521F79D0282A6FBEAAC37FE9C0BF5(L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		goto IL_000f;
	}

IL_000f:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_6 = V_0;
		return L_6;
	}
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean,UnityEngine.AudioClip_PCMReaderCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m36419CFB514ED329C3853136DC12C27A1BA65A37 (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ____3D4, bool ___stream5, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___pcmreadercallback6, const RuntimeMethod* method)
{
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_0 = NULL;
	{
		String_t* L_0 = ___name0;
		int32_t L_1 = ___lengthSamples1;
		int32_t L_2 = ___channels2;
		int32_t L_3 = ___frequency3;
		bool L_4 = ___stream5;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_5 = ___pcmreadercallback6;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_6 = AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995(L_0, L_1, L_2, L_3, L_4, L_5, (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)NULL, /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0012;
	}

IL_0012:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_7 = V_0;
		return L_7;
	}
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean,UnityEngine.AudioClip_PCMReaderCallback,UnityEngine.AudioClip_PCMSetPositionCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m523B7AF8F7CB12522A517F0C30D5EE6BFD555976 (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ____3D4, bool ___stream5, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___pcmreadercallback6, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___pcmsetpositioncallback7, const RuntimeMethod* method)
{
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_0 = NULL;
	{
		String_t* L_0 = ___name0;
		int32_t L_1 = ___lengthSamples1;
		int32_t L_2 = ___channels2;
		int32_t L_3 = ___frequency3;
		bool L_4 = ___stream5;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_5 = ___pcmreadercallback6;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_6 = ___pcmsetpositioncallback7;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_7 = AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995(L_0, L_1, L_2, L_3, L_4, L_5, L_6, /*hidden argument*/NULL);
		V_0 = L_7;
		goto IL_0013;
	}

IL_0013:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_8 = V_0;
		return L_8;
	}
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m76744E6CF5A521F79D0282A6FBEAAC37FE9C0BF5 (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, const RuntimeMethod* method)
{
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_0 = NULL;
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_1 = NULL;
	{
		String_t* L_0 = ___name0;
		int32_t L_1 = ___lengthSamples1;
		int32_t L_2 = ___channels2;
		int32_t L_3 = ___frequency3;
		bool L_4 = ___stream4;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_5 = AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995(L_0, L_1, L_2, L_3, L_4, (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)NULL, (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)NULL, /*hidden argument*/NULL);
		V_0 = L_5;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_6 = V_0;
		V_1 = L_6;
		goto IL_0013;
	}

IL_0013:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_7 = V_1;
		return L_7;
	}
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean,UnityEngine.AudioClip_PCMReaderCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m13B931474FD2B68CB5AF7F73132A773145608C5A (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___pcmreadercallback5, const RuntimeMethod* method)
{
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_0 = NULL;
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_1 = NULL;
	{
		String_t* L_0 = ___name0;
		int32_t L_1 = ___lengthSamples1;
		int32_t L_2 = ___channels2;
		int32_t L_3 = ___frequency3;
		bool L_4 = ___stream4;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_5 = ___pcmreadercallback5;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_6 = AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995(L_0, L_1, L_2, L_3, L_4, L_5, (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)NULL, /*hidden argument*/NULL);
		V_0 = L_6;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_7 = V_0;
		V_1 = L_7;
		goto IL_0014;
	}

IL_0014:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_8 = V_1;
		return L_8;
	}
}
// UnityEngine.AudioClip UnityEngine.AudioClip::Create(System.String,System.Int32,System.Int32,System.Int32,System.Boolean,UnityEngine.AudioClip_PCMReaderCallback,UnityEngine.AudioClip_PCMSetPositionCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995 (String_t* ___name0, int32_t ___lengthSamples1, int32_t ___channels2, int32_t ___frequency3, bool ___stream4, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___pcmreadercallback5, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___pcmsetpositioncallback6, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * V_7 = NULL;
	{
		String_t* L_0 = ___name0;
		V_1 = (bool)((((RuntimeObject*)(String_t*)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_000f;
		}
	}
	{
		NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC * L_2 = (NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC *)il2cpp_codegen_object_new(NullReferenceException_t204B194BC4DDA3259AF5A8633EA248AE5977ABDC_il2cpp_TypeInfo_var);
		NullReferenceException__ctor_m7D46E331C349DD29CBA488C9B6A950A3E7DD5CAE(L_2, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_RuntimeMethod_var);
	}

IL_000f:
	{
		int32_t L_3 = ___lengthSamples1;
		V_2 = (bool)((((int32_t)((((int32_t)L_3) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_4 = V_2;
		if (!L_4)
		{
			goto IL_0025;
		}
	}
	{
		ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * L_5 = (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 *)il2cpp_codegen_object_new(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7(L_5, _stringLiteral3AF0D3E9771A3768C7B73D9BC5347F23791C861D, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_RuntimeMethod_var);
	}

IL_0025:
	{
		int32_t L_6 = ___channels2;
		V_3 = (bool)((((int32_t)((((int32_t)L_6) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_3;
		if (!L_7)
		{
			goto IL_003b;
		}
	}
	{
		ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * L_8 = (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 *)il2cpp_codegen_object_new(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7(L_8, _stringLiteralA7AB925FF80AE6B8E928777122DF6848168541DC, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_RuntimeMethod_var);
	}

IL_003b:
	{
		int32_t L_9 = ___frequency3;
		V_4 = (bool)((((int32_t)((((int32_t)L_9) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_10 = V_4;
		if (!L_10)
		{
			goto IL_0053;
		}
	}
	{
		ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * L_11 = (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 *)il2cpp_codegen_object_new(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7(L_11, _stringLiteralEA3408619B25F828989F9D14D19C43095B82B903, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_11, AudioClip_Create_m7D20A6B52ACA39506B505EF162AF7EF81B173995_RuntimeMethod_var);
	}

IL_0053:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_12 = AudioClip_Construct_Internal_mEEA2165F0467FA67FA05361A85434DF5068E79B0(/*hidden argument*/NULL);
		V_0 = L_12;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_13 = ___pcmreadercallback5;
		V_5 = (bool)((!(((RuntimeObject*)(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)L_13) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_14 = V_5;
		if (!L_14)
		{
			goto IL_006d;
		}
	}
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_15 = V_0;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_16 = ___pcmreadercallback5;
		NullCheck(L_15);
		AudioClip_add_m_PCMReaderCallback_mE70789B25C74C552769FB2DAB96FC416A8508C62(L_15, L_16, /*hidden argument*/NULL);
	}

IL_006d:
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_17 = ___pcmsetpositioncallback6;
		V_6 = (bool)((!(((RuntimeObject*)(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)L_17) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_18 = V_6;
		if (!L_18)
		{
			goto IL_0081;
		}
	}
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_19 = V_0;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_20 = ___pcmsetpositioncallback6;
		NullCheck(L_19);
		AudioClip_add_m_PCMSetPositionCallback_mC0EBAE94510712D3E1481ED8B3FB7956169754F5(L_19, L_20, /*hidden argument*/NULL);
	}

IL_0081:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_21 = V_0;
		String_t* L_22 = ___name0;
		int32_t L_23 = ___lengthSamples1;
		int32_t L_24 = ___channels2;
		int32_t L_25 = ___frequency3;
		bool L_26 = ___stream4;
		NullCheck(L_21);
		AudioClip_CreateUserSound_m56B1F9909AB1F6CABCA8C526657F99A8BC0E73BD(L_21, L_22, L_23, L_24, L_25, L_26, /*hidden argument*/NULL);
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_27 = V_0;
		V_7 = L_27;
		goto IL_0093;
	}

IL_0093:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_28 = V_7;
		return L_28;
	}
}
// System.Void UnityEngine.AudioClip::add_m_PCMReaderCallback(UnityEngine.AudioClip_PCMReaderCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_add_m_PCMReaderCallback_mE70789B25C74C552769FB2DAB96FC416A8508C62 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_add_m_PCMReaderCallback_mE70789B25C74C552769FB2DAB96FC416A8508C62_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * V_0 = NULL;
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * V_1 = NULL;
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * V_2 = NULL;
	{
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_0 = __this->get_m_PCMReaderCallback_4();
		V_0 = L_0;
	}

IL_0007:
	{
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_1 = V_0;
		V_1 = L_1;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_2 = V_1;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_3 = ___value0;
		Delegate_t * L_4 = Delegate_Combine_mC25D2F7DECAFBA6D9A2F9EBA8A77063F0658ECF1(L_2, L_3, /*hidden argument*/NULL);
		V_2 = ((PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)CastclassSealed((RuntimeObject*)L_4, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB_il2cpp_TypeInfo_var));
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB ** L_5 = __this->get_address_of_m_PCMReaderCallback_4();
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_6 = V_2;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_7 = V_1;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_8 = InterlockedCompareExchangeImpl<PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *>((PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB **)L_5, L_6, L_7);
		V_0 = L_8;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_9 = V_0;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_10 = V_1;
		if ((!(((RuntimeObject*)(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)L_9) == ((RuntimeObject*)(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void UnityEngine.AudioClip::remove_m_PCMReaderCallback(UnityEngine.AudioClip_PCMReaderCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_remove_m_PCMReaderCallback_m0AEFEC9C086DEBABE06F1294AFE0B4031D805FE7 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_remove_m_PCMReaderCallback_m0AEFEC9C086DEBABE06F1294AFE0B4031D805FE7_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * V_0 = NULL;
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * V_1 = NULL;
	PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * V_2 = NULL;
	{
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_0 = __this->get_m_PCMReaderCallback_4();
		V_0 = L_0;
	}

IL_0007:
	{
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_1 = V_0;
		V_1 = L_1;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_2 = V_1;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_3 = ___value0;
		Delegate_t * L_4 = Delegate_Remove_m0B0DB7D1B3AF96B71AFAA72BA0EFE32FBBC2932D(L_2, L_3, /*hidden argument*/NULL);
		V_2 = ((PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)CastclassSealed((RuntimeObject*)L_4, PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB_il2cpp_TypeInfo_var));
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB ** L_5 = __this->get_address_of_m_PCMReaderCallback_4();
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_6 = V_2;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_7 = V_1;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_8 = InterlockedCompareExchangeImpl<PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *>((PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB **)L_5, L_6, L_7);
		V_0 = L_8;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_9 = V_0;
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_10 = V_1;
		if ((!(((RuntimeObject*)(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)L_9) == ((RuntimeObject*)(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void UnityEngine.AudioClip::add_m_PCMSetPositionCallback(UnityEngine.AudioClip_PCMSetPositionCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_add_m_PCMSetPositionCallback_mC0EBAE94510712D3E1481ED8B3FB7956169754F5 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_add_m_PCMSetPositionCallback_mC0EBAE94510712D3E1481ED8B3FB7956169754F5_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * V_0 = NULL;
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * V_1 = NULL;
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * V_2 = NULL;
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_0 = __this->get_m_PCMSetPositionCallback_5();
		V_0 = L_0;
	}

IL_0007:
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_1 = V_0;
		V_1 = L_1;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_2 = V_1;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_3 = ___value0;
		Delegate_t * L_4 = Delegate_Combine_mC25D2F7DECAFBA6D9A2F9EBA8A77063F0658ECF1(L_2, L_3, /*hidden argument*/NULL);
		V_2 = ((PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)CastclassSealed((RuntimeObject*)L_4, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801_il2cpp_TypeInfo_var));
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 ** L_5 = __this->get_address_of_m_PCMSetPositionCallback_5();
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_6 = V_2;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_7 = V_1;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_8 = InterlockedCompareExchangeImpl<PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *>((PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 **)L_5, L_6, L_7);
		V_0 = L_8;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_9 = V_0;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_10 = V_1;
		if ((!(((RuntimeObject*)(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)L_9) == ((RuntimeObject*)(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void UnityEngine.AudioClip::remove_m_PCMSetPositionCallback(UnityEngine.AudioClip_PCMSetPositionCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_remove_m_PCMSetPositionCallback_m21FB4ECFD0CE6C754C5D3BBFDCE9AD21E6D074A2 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioClip_remove_m_PCMSetPositionCallback_m21FB4ECFD0CE6C754C5D3BBFDCE9AD21E6D074A2_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * V_0 = NULL;
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * V_1 = NULL;
	PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * V_2 = NULL;
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_0 = __this->get_m_PCMSetPositionCallback_5();
		V_0 = L_0;
	}

IL_0007:
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_1 = V_0;
		V_1 = L_1;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_2 = V_1;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_3 = ___value0;
		Delegate_t * L_4 = Delegate_Remove_m0B0DB7D1B3AF96B71AFAA72BA0EFE32FBBC2932D(L_2, L_3, /*hidden argument*/NULL);
		V_2 = ((PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)CastclassSealed((RuntimeObject*)L_4, PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801_il2cpp_TypeInfo_var));
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 ** L_5 = __this->get_address_of_m_PCMSetPositionCallback_5();
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_6 = V_2;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_7 = V_1;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_8 = InterlockedCompareExchangeImpl<PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *>((PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 **)L_5, L_6, L_7);
		V_0 = L_8;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_9 = V_0;
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_10 = V_1;
		if ((!(((RuntimeObject*)(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)L_9) == ((RuntimeObject*)(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)L_10))))
		{
			goto IL_0007;
		}
	}
	{
		return;
	}
}
// System.Void UnityEngine.AudioClip::InvokePCMReaderCallback_Internal(System.Single[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_InvokePCMReaderCallback_Internal_mF087FCAD425EAC299C1156BA809DC535D00757F9 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_0 = __this->get_m_PCMReaderCallback_4();
		V_0 = (bool)((!(((RuntimeObject*)(PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * L_2 = __this->get_m_PCMReaderCallback_4();
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_3 = ___data0;
		NullCheck(L_2);
		PCMReaderCallback_Invoke_m7B101820DB35BEFC8D2724DF96900367863B93B6(L_2, L_3, /*hidden argument*/NULL);
	}

IL_001b:
	{
		return;
	}
}
// System.Void UnityEngine.AudioClip::InvokePCMSetPositionCallback_Internal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioClip_InvokePCMSetPositionCallback_Internal_mBB8265A5BFF660F8AF39718DDB193319AB7EFA6F (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * __this, int32_t ___position0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_0 = __this->get_m_PCMSetPositionCallback_5();
		V_0 = (bool)((!(((RuntimeObject*)(PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * L_2 = __this->get_m_PCMSetPositionCallback_5();
		int32_t L_3 = ___position0;
		NullCheck(L_2);
		PCMSetPositionCallback_Invoke_m8EA4736B43191A8E6F95E1548AFF124519EC533C(L_2, L_3, /*hidden argument*/NULL);
	}

IL_001b:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(float*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Marshaling of parameter '___data0' to native representation
	float* ____data0_marshaled = NULL;
	if (___data0 != NULL)
	{
		____data0_marshaled = reinterpret_cast<float*>((___data0)->GetAddressAtUnchecked(0));
	}

	// Native function invocation
	il2cppPInvokeFunc(____data0_marshaled);

}
// System.Void UnityEngine.AudioClip_PCMReaderCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMReaderCallback__ctor_mF9EB2467704F5E13196BBA93F41FA275AC5432F6 (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.AudioClip_PCMReaderCallback::Invoke(System.Single[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMReaderCallback_Invoke_m7B101820DB35BEFC8D2724DF96900367863B93B6 (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___data0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___data0, targetMethod);
			}
		}
		else if (___parameterCount != 1)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, ___data0);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, ___data0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___data0);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___data0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___data0, targetMethod);
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___data0, targetMethod);
				}
				else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* >::Invoke(targetMethod, targetThis, ___data0);
					else
						GenericVirtActionInvoker1< SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* >::Invoke(targetMethod, targetThis, ___data0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___data0);
					else
						VirtActionInvoker1< SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___data0);
				}
			}
			else
			{
				if (targetThis == NULL && il2cpp_codegen_class_is_value_type(il2cpp_codegen_method_get_declaring_type(targetMethod)))
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((reinterpret_cast<RuntimeObject*>(___data0) - 1), targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___data0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.AudioClip_PCMReaderCallback::BeginInvoke(System.Single[],System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PCMReaderCallback_BeginInvoke_m94035E11B2B9BD6114EF3D7F4B7E367572E7AE1F (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___data0, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	void *__d_args[2] = {0};
	__d_args[0] = ___data0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void UnityEngine.AudioClip_PCMReaderCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMReaderCallback_EndInvoke_m6730FD7DFD7246F137C437BC470F995D6C75E15B (PCMReaderCallback_t9B87AB13DCD37957B045554BF28A57697E6B8EFB * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * __this, int32_t ___position0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Native function invocation
	il2cppPInvokeFunc(___position0);

}
// System.Void UnityEngine.AudioClip_PCMSetPositionCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMSetPositionCallback__ctor_m31EA578C3CCFDFC9335B8C67353878AEE4B3905F (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.AudioClip_PCMSetPositionCallback::Invoke(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMSetPositionCallback_Invoke_m8EA4736B43191A8E6F95E1548AFF124519EC533C (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * __this, int32_t ___position0, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___position0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___position0, targetMethod);
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (int32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___position0, targetMethod);
				}
				else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< int32_t >::Invoke(targetMethod, targetThis, ___position0);
					else
						GenericVirtActionInvoker1< int32_t >::Invoke(targetMethod, targetThis, ___position0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___position0);
					else
						VirtActionInvoker1< int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___position0);
				}
			}
			else
			{
				if (targetThis == NULL && il2cpp_codegen_class_is_value_type(il2cpp_codegen_method_get_declaring_type(targetMethod)))
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((reinterpret_cast<RuntimeObject*>(&___position0) - 1), targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, int32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___position0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.AudioClip_PCMSetPositionCallback::BeginInvoke(System.Int32,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PCMSetPositionCallback_BeginInvoke_m88CDF70D75854621CA69ED3D53CD53B8206A5093 (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * __this, int32_t ___position0, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (PCMSetPositionCallback_BeginInvoke_m88CDF70D75854621CA69ED3D53CD53B8206A5093_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var, &___position0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void UnityEngine.AudioClip_PCMSetPositionCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PCMSetPositionCallback_EndInvoke_mB711E23CFD370348A1680B281A3DFE04F970792C (PCMSetPositionCallback_t092ED33043C0279B5E4D343EBCBD516CEF260801 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.AudioSettings::InvokeOnAudioConfigurationChanged(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSettings_InvokeOnAudioConfigurationChanged_m8D251791C6A402B12E93C22F43475DE3033FC8E7 (bool ___deviceWasChanged0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSettings_InvokeOnAudioConfigurationChanged_m8D251791C6A402B12E93C22F43475DE3033FC8E7_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * L_0 = ((AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_StaticFields*)il2cpp_codegen_static_fields_for(AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_il2cpp_TypeInfo_var))->get_OnAudioConfigurationChanged_0();
		V_0 = (bool)((!(((RuntimeObject*)(AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * L_2 = ((AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_StaticFields*)il2cpp_codegen_static_fields_for(AudioSettings_t77B5D69F704CF3B710B0B6970BB62A4BF25A5B31_il2cpp_TypeInfo_var))->get_OnAudioConfigurationChanged_0();
		bool L_3 = ___deviceWasChanged0;
		NullCheck(L_2);
		AudioConfigurationChangeHandler_Invoke_m62D72B397E1DC117C8C92A450D2C86C535A2BF49(L_2, L_3, /*hidden argument*/NULL);
	}

IL_0019:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 (AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * __this, bool ___deviceWasChanged0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Native function invocation
	il2cppPInvokeFunc(static_cast<int32_t>(___deviceWasChanged0));

}
// System.Void UnityEngine.AudioSettings_AudioConfigurationChangeHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioConfigurationChangeHandler__ctor_mF9399769D5BB18D740774B9E3129958868BD6D9A (AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.AudioSettings_AudioConfigurationChangeHandler::Invoke(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioConfigurationChangeHandler_Invoke_m62D72B397E1DC117C8C92A450D2C86C535A2BF49 (AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * __this, bool ___deviceWasChanged0, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (bool, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___deviceWasChanged0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, bool, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___deviceWasChanged0, targetMethod);
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (bool, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___deviceWasChanged0, targetMethod);
				}
				else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< bool >::Invoke(targetMethod, targetThis, ___deviceWasChanged0);
					else
						GenericVirtActionInvoker1< bool >::Invoke(targetMethod, targetThis, ___deviceWasChanged0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< bool >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___deviceWasChanged0);
					else
						VirtActionInvoker1< bool >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___deviceWasChanged0);
				}
			}
			else
			{
				if (targetThis == NULL && il2cpp_codegen_class_is_value_type(il2cpp_codegen_method_get_declaring_type(targetMethod)))
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((reinterpret_cast<RuntimeObject*>(&___deviceWasChanged0) - 1), targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, bool, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___deviceWasChanged0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.AudioSettings_AudioConfigurationChangeHandler::BeginInvoke(System.Boolean,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* AudioConfigurationChangeHandler_BeginInvoke_mB0B0ACF6281B999FA11037CA130CA3C72BEC7827 (AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * __this, bool ___deviceWasChanged0, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioConfigurationChangeHandler_BeginInvoke_mB0B0ACF6281B999FA11037CA130CA3C72BEC7827_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_il2cpp_TypeInfo_var, &___deviceWasChanged0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void UnityEngine.AudioSettings_AudioConfigurationChangeHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioConfigurationChangeHandler_EndInvoke_mBB53599C34E3944D3A1DD71EFD2D73AF105CF830 (AudioConfigurationChangeHandler_t8E0E05D0198D95B5412DC716F87D97020EF54926 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Single UnityEngine.AudioSource::GetPitch(UnityEngine.AudioSource)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_GetPitch_m76B68079F309EB1FE2BFF4A0B014B89780B383CA (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, const RuntimeMethod* method)
{
	typedef float (*AudioSource_GetPitch_m76B68079F309EB1FE2BFF4A0B014B89780B383CA_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_GetPitch_m76B68079F309EB1FE2BFF4A0B014B89780B383CA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_GetPitch_m76B68079F309EB1FE2BFF4A0B014B89780B383CA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::GetPitch(UnityEngine.AudioSource)");
	float retVal = _il2cpp_icall_func(___source0);
	return retVal;
}
// System.Void UnityEngine.AudioSource::SetPitch(UnityEngine.AudioSource,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetPitch_mB65EF59C56A49FD68CD3361B2C34E07F89F1244B (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, float ___pitch1, const RuntimeMethod* method)
{
	typedef void (*AudioSource_SetPitch_mB65EF59C56A49FD68CD3361B2C34E07F89F1244B_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_SetPitch_mB65EF59C56A49FD68CD3361B2C34E07F89F1244B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_SetPitch_mB65EF59C56A49FD68CD3361B2C34E07F89F1244B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::SetPitch(UnityEngine.AudioSource,System.Single)");
	_il2cpp_icall_func(___source0, ___pitch1);
}
// System.Void UnityEngine.AudioSource::PlayHelper(UnityEngine.AudioSource,System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, uint64_t ___delay1, const RuntimeMethod* method)
{
	typedef void (*AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, uint64_t);
	static AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::PlayHelper(UnityEngine.AudioSource,System.UInt64)");
	_il2cpp_icall_func(___source0, ___delay1);
}
// System.Void UnityEngine.AudioSource::Play(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, double ___delay0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, double);
	static AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::Play(System.Double)");
	_il2cpp_icall_func(__this, ___delay0);
}
// System.Void UnityEngine.AudioSource::PlayOneShotHelper(UnityEngine.AudioSource,UnityEngine.AudioClip,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayOneShotHelper_mDAEDF5E0C56C665DE62CDF26E7B98149B4A71704 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip1, float ___volumeScale2, const RuntimeMethod* method)
{
	typedef void (*AudioSource_PlayOneShotHelper_mDAEDF5E0C56C665DE62CDF26E7B98149B4A71704_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *, float);
	static AudioSource_PlayOneShotHelper_mDAEDF5E0C56C665DE62CDF26E7B98149B4A71704_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_PlayOneShotHelper_mDAEDF5E0C56C665DE62CDF26E7B98149B4A71704_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::PlayOneShotHelper(UnityEngine.AudioSource,UnityEngine.AudioClip,System.Single)");
	_il2cpp_icall_func(___source0, ___clip1, ___volumeScale2);
}
// System.Void UnityEngine.AudioSource::Stop(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Stop_mD3712B98BC6DBEA9CEEF778CE9CCB8DBA62F47A8 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___stopOneShots0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_Stop_mD3712B98BC6DBEA9CEEF778CE9CCB8DBA62F47A8_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_Stop_mD3712B98BC6DBEA9CEEF778CE9CCB8DBA62F47A8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_Stop_mD3712B98BC6DBEA9CEEF778CE9CCB8DBA62F47A8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::Stop(System.Boolean)");
	_il2cpp_icall_func(__this, ___stopOneShots0);
}
// System.Void UnityEngine.AudioSource::SetCustomCurveHelper(UnityEngine.AudioSource,UnityEngine.AudioSourceCurveType,UnityEngine.AnimationCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetCustomCurveHelper_mB444ACB3E7BF771A4E724310A44669D5F1236C23 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, int32_t ___type1, AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * ___curve2, const RuntimeMethod* method)
{
	typedef void (*AudioSource_SetCustomCurveHelper_mB444ACB3E7BF771A4E724310A44669D5F1236C23_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t, AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C *);
	static AudioSource_SetCustomCurveHelper_mB444ACB3E7BF771A4E724310A44669D5F1236C23_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_SetCustomCurveHelper_mB444ACB3E7BF771A4E724310A44669D5F1236C23_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::SetCustomCurveHelper(UnityEngine.AudioSource,UnityEngine.AudioSourceCurveType,UnityEngine.AnimationCurve)");
	_il2cpp_icall_func(___source0, ___type1, ___curve2);
}
// UnityEngine.AnimationCurve UnityEngine.AudioSource::GetCustomCurveHelper(UnityEngine.AudioSource,UnityEngine.AudioSourceCurveType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * AudioSource_GetCustomCurveHelper_m0D5A8403CAC89257DF8ACD15C514A5DE621BF749 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, int32_t ___type1, const RuntimeMethod* method)
{
	typedef AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * (*AudioSource_GetCustomCurveHelper_m0D5A8403CAC89257DF8ACD15C514A5DE621BF749_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t);
	static AudioSource_GetCustomCurveHelper_m0D5A8403CAC89257DF8ACD15C514A5DE621BF749_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_GetCustomCurveHelper_m0D5A8403CAC89257DF8ACD15C514A5DE621BF749_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::GetCustomCurveHelper(UnityEngine.AudioSource,UnityEngine.AudioSourceCurveType)");
	AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * retVal = _il2cpp_icall_func(___source0, ___type1);
	return retVal;
}
// System.Void UnityEngine.AudioSource::GetOutputDataHelper(UnityEngine.AudioSource,System.Single[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___samples1, int32_t ___channel2, const RuntimeMethod* method)
{
	typedef void (*AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, int32_t);
	static AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::GetOutputDataHelper(UnityEngine.AudioSource,System.Single[],System.Int32)");
	_il2cpp_icall_func(___source0, ___samples1, ___channel2);
}
// System.Void UnityEngine.AudioSource::GetSpectrumDataHelper(UnityEngine.AudioSource,System.Single[],System.Int32,UnityEngine.FFTWindow)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * ___source0, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___samples1, int32_t ___channel2, int32_t ___window3, const RuntimeMethod* method)
{
	typedef void (*AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*, int32_t, int32_t);
	static AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::GetSpectrumDataHelper(UnityEngine.AudioSource,System.Single[],System.Int32,UnityEngine.FFTWindow)");
	_il2cpp_icall_func(___source0, ___samples1, ___channel2, ___window3);
}
// System.Single UnityEngine.AudioSource::get_volume()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_volume_mBD65DB423F0520CDCB935CC593565343965A4CB0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_volume_mBD65DB423F0520CDCB935CC593565343965A4CB0_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_volume_mBD65DB423F0520CDCB935CC593565343965A4CB0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_volume_mBD65DB423F0520CDCB935CC593565343965A4CB0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_volume()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_volume(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_volume_mF1757D70EE113871724334D13F70EF1ED033BA06 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_volume_mF1757D70EE113871724334D13F70EF1ED033BA06_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_volume_mF1757D70EE113871724334D13F70EF1ED033BA06_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_volume_mF1757D70EE113871724334D13F70EF1ED033BA06_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_volume(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_pitch()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_pitch_m70F33CAA7F869F88AB78BFEFA7385CF533F9B50D (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = AudioSource_GetPitch_m76B68079F309EB1FE2BFF4A0B014B89780B383CA(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.AudioSource::set_pitch(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_pitch_mAB8F8CDB21A3139D3471784FEE9DBFA4CEDEE2E0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	{
		float L_0 = ___value0;
		AudioSource_SetPitch_mB65EF59C56A49FD68CD3361B2C34E07F89F1244B(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.AudioSource::get_time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_time_m9EE836ADDDAB3598FD7F6D198F847C43E0FFBF52 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_time_m9EE836ADDDAB3598FD7F6D198F847C43E0FFBF52_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_time_m9EE836ADDDAB3598FD7F6D198F847C43E0FFBF52_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_time_m9EE836ADDDAB3598FD7F6D198F847C43E0FFBF52_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_time()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_time(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_time_m76B72F7AEF8B07469847BF8EFFC51991C9D695B1 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_time_m76B72F7AEF8B07469847BF8EFFC51991C9D695B1_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_time_m76B72F7AEF8B07469847BF8EFFC51991C9D695B1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_time_m76B72F7AEF8B07469847BF8EFFC51991C9D695B1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_time(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Int32 UnityEngine.AudioSource::get_timeSamples()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioSource_get_timeSamples_m0E3467605A8D6CBFA36D6F167E4D663DA2D17EE7 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioSource_get_timeSamples_m0E3467605A8D6CBFA36D6F167E4D663DA2D17EE7_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_timeSamples_m0E3467605A8D6CBFA36D6F167E4D663DA2D17EE7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_timeSamples_m0E3467605A8D6CBFA36D6F167E4D663DA2D17EE7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_timeSamples()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_timeSamples(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_timeSamples_m0080C96DD5EF182E40D63272E086FEE32F541CA0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_timeSamples_m0080C96DD5EF182E40D63272E086FEE32F541CA0_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t);
	static AudioSource_set_timeSamples_m0080C96DD5EF182E40D63272E086FEE32F541CA0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_timeSamples_m0080C96DD5EF182E40D63272E086FEE32F541CA0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_timeSamples(System.Int32)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.AudioClip UnityEngine.AudioSource::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * AudioSource_get_clip_m773ECEF5566EA64C74E316D7EF1A63AA01604643 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * (*AudioSource_get_clip_m773ECEF5566EA64C74E316D7EF1A63AA01604643_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_clip_m773ECEF5566EA64C74E316D7EF1A63AA01604643_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_clip_m773ECEF5566EA64C74E316D7EF1A63AA01604643_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_clip()");
	AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_clip(UnityEngine.AudioClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_clip_mF574231E0B749E0167CAF9E4FCBA06BAA0F9ED9B (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_clip_mF574231E0B749E0167CAF9E4FCBA06BAA0F9ED9B_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 *);
	static AudioSource_set_clip_mF574231E0B749E0167CAF9E4FCBA06BAA0F9ED9B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_clip_mF574231E0B749E0167CAF9E4FCBA06BAA0F9ED9B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_clip(UnityEngine.AudioClip)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Audio.AudioMixerGroup UnityEngine.AudioSource::get_outputAudioMixerGroup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9 * AudioSource_get_outputAudioMixerGroup_m6582826E5DBB0E210AE5DE0974F1D4BC945A78D7 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9 * (*AudioSource_get_outputAudioMixerGroup_m6582826E5DBB0E210AE5DE0974F1D4BC945A78D7_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_outputAudioMixerGroup_m6582826E5DBB0E210AE5DE0974F1D4BC945A78D7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_outputAudioMixerGroup_m6582826E5DBB0E210AE5DE0974F1D4BC945A78D7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_outputAudioMixerGroup()");
	AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9 * retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_outputAudioMixerGroup_mC153530274A1109635889A23646E1F5BA5C150E1 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9 * ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_outputAudioMixerGroup_mC153530274A1109635889A23646E1F5BA5C150E1_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, AudioMixerGroup_t425B8680E1F9F0D7A828199A017BF61516AC7CD9 *);
	static AudioSource_set_outputAudioMixerGroup_mC153530274A1109635889A23646E1F5BA5C150E1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_outputAudioMixerGroup_mC153530274A1109635889A23646E1F5BA5C150E1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.AudioSource::Play()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Play_m0BA206481892AA4AF7DB2900A0B0805076516164 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	{
		AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC(__this, (((int64_t)((int64_t)0))), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::Play(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Play_m442DC027196BE23536B5806E13B2F9D6D1A2ED74 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, uint64_t ___delay0, const RuntimeMethod* method)
{
	{
		uint64_t L_0 = ___delay0;
		AudioSource_PlayHelper_m361C17B583E05D2A5FA0F03BD7CD98D74FBF83AC(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::PlayDelayed(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayDelayed_m9C5DCC1E8BC219DACBEB0907D7BF9A9AF7174CE1 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___delay0, const RuntimeMethod* method)
{
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * G_B2_0 = NULL;
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * G_B1_0 = NULL;
	double G_B3_0 = 0.0;
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * G_B3_1 = NULL;
	{
		float L_0 = ___delay0;
		G_B1_0 = __this;
		if ((((float)L_0) < ((float)(0.0f))))
		{
			G_B2_0 = __this;
			goto IL_000f;
		}
	}
	{
		float L_1 = ___delay0;
		G_B3_0 = ((-(((double)((double)L_1)))));
		G_B3_1 = G_B1_0;
		goto IL_0018;
	}

IL_000f:
	{
		G_B3_0 = (0.0);
		G_B3_1 = G_B2_0;
	}

IL_0018:
	{
		NullCheck(G_B3_1);
		AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::PlayScheduled(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayScheduled_m3BCBE6A805705D2697A33C9A14053999D80C929F (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, double ___time0, const RuntimeMethod* method)
{
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * G_B2_0 = NULL;
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * G_B1_0 = NULL;
	double G_B3_0 = 0.0;
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * G_B3_1 = NULL;
	{
		double L_0 = ___time0;
		G_B1_0 = __this;
		if ((((double)L_0) < ((double)(0.0))))
		{
			G_B2_0 = __this;
			goto IL_0011;
		}
	}
	{
		double L_1 = ___time0;
		G_B3_0 = L_1;
		G_B3_1 = G_B1_0;
		goto IL_001a;
	}

IL_0011:
	{
		G_B3_0 = (0.0);
		G_B3_1 = G_B2_0;
	}

IL_001a:
	{
		NullCheck(G_B3_1);
		AudioSource_Play_m5F47EF396B3230E70CF138E9F9AEFFB90AA7C0F0(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::PlayOneShot(UnityEngine.AudioClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayOneShot_mFD68566752A61B9C54843650A5C6075DBBFC56CD (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, const RuntimeMethod* method)
{
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_0 = ___clip0;
		AudioSource_PlayOneShot_mA65B809A4480039CD8337ABF45C0E57E137EED41(__this, L_0, (1.0f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::PlayOneShot(UnityEngine.AudioClip,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayOneShot_mA65B809A4480039CD8337ABF45C0E57E137EED41 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, float ___volumeScale1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_PlayOneShot_mA65B809A4480039CD8337ABF45C0E57E137EED41_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_0 = ___clip0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		bool L_1 = Object_op_Equality_mBC2401774F3BE33E8CF6F0A8148E66C95D6CFF1C(L_0, (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 *)NULL, /*hidden argument*/NULL);
		V_0 = L_1;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogWarning_m37338644DC81F640CCDFEAE35A223F0E965F0568(_stringLiteral2F43397615CF615962F130AA6604F6D76A60AE5C, /*hidden argument*/NULL);
		goto IL_0023;
	}

IL_001a:
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_3 = ___clip0;
		float L_4 = ___volumeScale1;
		AudioSource_PlayOneShotHelper_mDAEDF5E0C56C665DE62CDF26E7B98149B4A71704(__this, L_3, L_4, /*hidden argument*/NULL);
	}

IL_0023:
	{
		return;
	}
}
// System.Void UnityEngine.AudioSource::SetScheduledStartTime(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetScheduledStartTime_mE6C5FAC81B708867208E090D6E2D83D7882D644D (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, double ___time0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_SetScheduledStartTime_mE6C5FAC81B708867208E090D6E2D83D7882D644D_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, double);
	static AudioSource_SetScheduledStartTime_mE6C5FAC81B708867208E090D6E2D83D7882D644D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_SetScheduledStartTime_mE6C5FAC81B708867208E090D6E2D83D7882D644D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::SetScheduledStartTime(System.Double)");
	_il2cpp_icall_func(__this, ___time0);
}
// System.Void UnityEngine.AudioSource::SetScheduledEndTime(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetScheduledEndTime_m3EC07F1D83FD052CCC7395CBE91FD45CD40009FF (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, double ___time0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_SetScheduledEndTime_m3EC07F1D83FD052CCC7395CBE91FD45CD40009FF_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, double);
	static AudioSource_SetScheduledEndTime_m3EC07F1D83FD052CCC7395CBE91FD45CD40009FF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_SetScheduledEndTime_m3EC07F1D83FD052CCC7395CBE91FD45CD40009FF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::SetScheduledEndTime(System.Double)");
	_il2cpp_icall_func(__this, ___time0);
}
// System.Void UnityEngine.AudioSource::Stop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Stop_m488F7AA7F7067DE3EC92CEE3413E86C2E5940200 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	{
		AudioSource_Stop_mD3712B98BC6DBEA9CEEF778CE9CCB8DBA62F47A8(__this, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::Pause()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_Pause_m279B116A62699983F6B5347FD4770358D7794F3C (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef void (*AudioSource_Pause_m279B116A62699983F6B5347FD4770358D7794F3C_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_Pause_m279B116A62699983F6B5347FD4770358D7794F3C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_Pause_m279B116A62699983F6B5347FD4770358D7794F3C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::Pause()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.AudioSource::UnPause()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_UnPause_m6FEDC709B978288009CDFDDC519A7D625D27A1CB (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef void (*AudioSource_UnPause_m6FEDC709B978288009CDFDDC519A7D625D27A1CB_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_UnPause_m6FEDC709B978288009CDFDDC519A7D625D27A1CB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_UnPause_m6FEDC709B978288009CDFDDC519A7D625D27A1CB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::UnPause()");
	_il2cpp_icall_func(__this);
}
// System.Boolean UnityEngine.AudioSource::get_isPlaying()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_isPlaying_m5112A878573652681F40C82F0D8103C999978F3C (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_isPlaying_m5112A878573652681F40C82F0D8103C999978F3C_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_isPlaying_m5112A878573652681F40C82F0D8103C999978F3C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_isPlaying_m5112A878573652681F40C82F0D8103C999978F3C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_isPlaying()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Boolean UnityEngine.AudioSource::get_isVirtual()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_isVirtual_m1BA78D0BD4E2E2D005FD2EDDE1E0053D926C609E (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_isVirtual_m1BA78D0BD4E2E2D005FD2EDDE1E0053D926C609E_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_isVirtual_m1BA78D0BD4E2E2D005FD2EDDE1E0053D926C609E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_isVirtual_m1BA78D0BD4E2E2D005FD2EDDE1E0053D926C609E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_isVirtual()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::PlayClipAtPoint(UnityEngine.AudioClip,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayClipAtPoint_mAD2719E8188F33573035F1F2116BC194202EC117 (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___position1, const RuntimeMethod* method)
{
	{
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_0 = ___clip0;
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___position1;
		AudioSource_PlayClipAtPoint_m484E3DF855E6D40448E5AAED9D77846617B8C0CE(L_0, L_1, (1.0f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AudioSource::PlayClipAtPoint(UnityEngine.AudioClip,UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_PlayClipAtPoint_m484E3DF855E6D40448E5AAED9D77846617B8C0CE (AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * ___clip0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___position1, float ___volume2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_PlayClipAtPoint_m484E3DF855E6D40448E5AAED9D77846617B8C0CE_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * V_0 = NULL;
	AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * V_1 = NULL;
	float G_B2_0 = 0.0f;
	GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * G_B2_1 = NULL;
	float G_B1_0 = 0.0f;
	GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * G_B1_1 = NULL;
	float G_B3_0 = 0.0f;
	float G_B3_1 = 0.0f;
	GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * G_B3_2 = NULL;
	{
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_0 = (GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F *)il2cpp_codegen_object_new(GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F_il2cpp_TypeInfo_var);
		GameObject__ctor_mBB454E679AD9CF0B84D3609A01E6A9753ACF4686(L_0, _stringLiteral3CAE8FFCB80F093CACA64555228254ABA8C246B9, /*hidden argument*/NULL);
		V_0 = L_0;
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_1 = V_0;
		NullCheck(L_1);
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_2 = GameObject_get_transform_mA5C38857137F137CB96C69FAA624199EB1C2FB2C(L_1, /*hidden argument*/NULL);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_3 = ___position1;
		NullCheck(L_2);
		Transform_set_position_mDA89E4893F14ECA5CBEEE7FB80A5BF7C1B8EA6DC(L_2, L_3, /*hidden argument*/NULL);
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_4 = V_0;
		RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_5 = { reinterpret_cast<intptr_t> (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_6 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_5, /*hidden argument*/NULL);
		NullCheck(L_4);
		Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621 * L_7 = GameObject_AddComponent_m489C9D5426F2050795FA696CD478BB49AAE4BD70(L_4, L_6, /*hidden argument*/NULL);
		V_1 = ((AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *)CastclassSealed((RuntimeObject*)L_7, AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C_il2cpp_TypeInfo_var));
		AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * L_8 = V_1;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_9 = ___clip0;
		NullCheck(L_8);
		AudioSource_set_clip_mF574231E0B749E0167CAF9E4FCBA06BAA0F9ED9B(L_8, L_9, /*hidden argument*/NULL);
		AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * L_10 = V_1;
		NullCheck(L_10);
		AudioSource_set_spatialBlend_mC144B8230F08743505D4B0A92C1B9F809BC6D9C5(L_10, (1.0f), /*hidden argument*/NULL);
		AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * L_11 = V_1;
		float L_12 = ___volume2;
		NullCheck(L_11);
		AudioSource_set_volume_mF1757D70EE113871724334D13F70EF1ED033BA06(L_11, L_12, /*hidden argument*/NULL);
		AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * L_13 = V_1;
		NullCheck(L_13);
		AudioSource_Play_m0BA206481892AA4AF7DB2900A0B0805076516164(L_13, /*hidden argument*/NULL);
		GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * L_14 = V_0;
		AudioClip_tCC3C35F579203CE2601243585AB3D6953C3BA051 * L_15 = ___clip0;
		NullCheck(L_15);
		float L_16 = AudioClip_get_length_mFF1E21363B1860453451C4DA1C1459E9B9504317(L_15, /*hidden argument*/NULL);
		float L_17 = Time_get_timeScale_m7E198A5814859A08FD0FFE6DD5F7ED5C907719F8(/*hidden argument*/NULL);
		G_B1_0 = L_16;
		G_B1_1 = L_14;
		if ((((float)L_17) < ((float)(0.01f))))
		{
			G_B2_0 = L_16;
			G_B2_1 = L_14;
			goto IL_006c;
		}
	}
	{
		float L_18 = Time_get_timeScale_m7E198A5814859A08FD0FFE6DD5F7ED5C907719F8(/*hidden argument*/NULL);
		G_B3_0 = L_18;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		goto IL_0071;
	}

IL_006c:
	{
		G_B3_0 = (0.01f);
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
	}

IL_0071:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		Object_Destroy_m09F51D8BDECFD2E8C618498EF7377029B669030D(G_B3_2, ((float)il2cpp_codegen_multiply((float)G_B3_1, (float)G_B3_0)), /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.AudioSource::get_loop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_loop_m576259B36687CA2327106F945A3E49E3D74A7F90 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_loop_m576259B36687CA2327106F945A3E49E3D74A7F90_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_loop_m576259B36687CA2327106F945A3E49E3D74A7F90_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_loop_m576259B36687CA2327106F945A3E49E3D74A7F90_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_loop()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_loop(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_loop_m4DEE785C31213E964D7014B633F0FFC7E98B79F4 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_loop_m4DEE785C31213E964D7014B633F0FFC7E98B79F4_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_loop_m4DEE785C31213E964D7014B633F0FFC7E98B79F4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_loop_m4DEE785C31213E964D7014B633F0FFC7E98B79F4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_loop(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_ignoreListenerVolume()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_ignoreListenerVolume_mF12EEF4A236D621162CE225ECCD7B175B92E59BE (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_ignoreListenerVolume_mF12EEF4A236D621162CE225ECCD7B175B92E59BE_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_ignoreListenerVolume_mF12EEF4A236D621162CE225ECCD7B175B92E59BE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_ignoreListenerVolume_mF12EEF4A236D621162CE225ECCD7B175B92E59BE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_ignoreListenerVolume()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_ignoreListenerVolume(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_ignoreListenerVolume_m62400A4AC76F3DD1DCBD9CEAA89460A022C64227 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_ignoreListenerVolume_m62400A4AC76F3DD1DCBD9CEAA89460A022C64227_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_ignoreListenerVolume_m62400A4AC76F3DD1DCBD9CEAA89460A022C64227_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_ignoreListenerVolume_m62400A4AC76F3DD1DCBD9CEAA89460A022C64227_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_ignoreListenerVolume(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_playOnAwake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_playOnAwake_mFCCEA6BF78DC708ABD1DCC7BC8BE79EA0CFC3AE0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_playOnAwake_mFCCEA6BF78DC708ABD1DCC7BC8BE79EA0CFC3AE0_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_playOnAwake_mFCCEA6BF78DC708ABD1DCC7BC8BE79EA0CFC3AE0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_playOnAwake_mFCCEA6BF78DC708ABD1DCC7BC8BE79EA0CFC3AE0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_playOnAwake()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_playOnAwake(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_playOnAwake_m5E4C76260D66898EEFEB20E4F42B6249AACB4128 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_playOnAwake_m5E4C76260D66898EEFEB20E4F42B6249AACB4128_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_playOnAwake_m5E4C76260D66898EEFEB20E4F42B6249AACB4128_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_playOnAwake_m5E4C76260D66898EEFEB20E4F42B6249AACB4128_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_playOnAwake(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_ignoreListenerPause()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_ignoreListenerPause_m6A940BC8FCDC83B97372B9BE244BFE58F5FC8FD8 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_ignoreListenerPause_m6A940BC8FCDC83B97372B9BE244BFE58F5FC8FD8_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_ignoreListenerPause_m6A940BC8FCDC83B97372B9BE244BFE58F5FC8FD8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_ignoreListenerPause_m6A940BC8FCDC83B97372B9BE244BFE58F5FC8FD8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_ignoreListenerPause()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_ignoreListenerPause(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_ignoreListenerPause_m12E096197FC8998A4C570442B4389299F7185238 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_ignoreListenerPause_m12E096197FC8998A4C570442B4389299F7185238_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_ignoreListenerPause_m12E096197FC8998A4C570442B4389299F7185238_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_ignoreListenerPause_m12E096197FC8998A4C570442B4389299F7185238_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_ignoreListenerPause(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.AudioVelocityUpdateMode UnityEngine.AudioSource::get_velocityUpdateMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioSource_get_velocityUpdateMode_m846BE29AA8C801B0631EEDE787B15456CF5C61F9 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioSource_get_velocityUpdateMode_m846BE29AA8C801B0631EEDE787B15456CF5C61F9_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_velocityUpdateMode_m846BE29AA8C801B0631EEDE787B15456CF5C61F9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_velocityUpdateMode_m846BE29AA8C801B0631EEDE787B15456CF5C61F9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_velocityUpdateMode()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_velocityUpdateMode(UnityEngine.AudioVelocityUpdateMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_velocityUpdateMode_m9D5B3C54EE308B05B103175E3D892F05134DF92D (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_velocityUpdateMode_m9D5B3C54EE308B05B103175E3D892F05134DF92D_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t);
	static AudioSource_set_velocityUpdateMode_m9D5B3C54EE308B05B103175E3D892F05134DF92D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_velocityUpdateMode_m9D5B3C54EE308B05B103175E3D892F05134DF92D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_velocityUpdateMode(UnityEngine.AudioVelocityUpdateMode)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_panStereo()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_panStereo_m3E7E4E78DF624E34E3630E0EF1BA4845F9C421DA (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_panStereo_m3E7E4E78DF624E34E3630E0EF1BA4845F9C421DA_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_panStereo_m3E7E4E78DF624E34E3630E0EF1BA4845F9C421DA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_panStereo_m3E7E4E78DF624E34E3630E0EF1BA4845F9C421DA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_panStereo()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_panStereo(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_panStereo_mBE007C40EDA2FEBA5F5192EB895039B07167BF60 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_panStereo_mBE007C40EDA2FEBA5F5192EB895039B07167BF60_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_panStereo_mBE007C40EDA2FEBA5F5192EB895039B07167BF60_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_panStereo_mBE007C40EDA2FEBA5F5192EB895039B07167BF60_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_panStereo(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_spatialBlend()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_spatialBlend_mE43E63FB77B0BA35F2494ED234F16945D0801759 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_spatialBlend_mE43E63FB77B0BA35F2494ED234F16945D0801759_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_spatialBlend_mE43E63FB77B0BA35F2494ED234F16945D0801759_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_spatialBlend_mE43E63FB77B0BA35F2494ED234F16945D0801759_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_spatialBlend()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_spatialBlend(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spatialBlend_mC144B8230F08743505D4B0A92C1B9F809BC6D9C5 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_spatialBlend_mC144B8230F08743505D4B0A92C1B9F809BC6D9C5_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_spatialBlend_mC144B8230F08743505D4B0A92C1B9F809BC6D9C5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_spatialBlend_mC144B8230F08743505D4B0A92C1B9F809BC6D9C5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_spatialBlend(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_spatialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_spatialize_m8CC430356EDE4FF4BD31A5F5509028B7DDCC4C11 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_spatialize_m8CC430356EDE4FF4BD31A5F5509028B7DDCC4C11_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_spatialize_m8CC430356EDE4FF4BD31A5F5509028B7DDCC4C11_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_spatialize_m8CC430356EDE4FF4BD31A5F5509028B7DDCC4C11_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_spatialize()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_spatialize(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spatialize_m67B01FA31D125E7A6E3E20A56A781D1E9200D8FD (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_spatialize_m67B01FA31D125E7A6E3E20A56A781D1E9200D8FD_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_spatialize_m67B01FA31D125E7A6E3E20A56A781D1E9200D8FD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_spatialize_m67B01FA31D125E7A6E3E20A56A781D1E9200D8FD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_spatialize(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_spatializePostEffects()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_spatializePostEffects_m038F7F6D72B2A0D9D8F8483081747257286FDAB2 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_spatializePostEffects_m038F7F6D72B2A0D9D8F8483081747257286FDAB2_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_spatializePostEffects_m038F7F6D72B2A0D9D8F8483081747257286FDAB2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_spatializePostEffects_m038F7F6D72B2A0D9D8F8483081747257286FDAB2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_spatializePostEffects()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_spatializePostEffects(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spatializePostEffects_m7030C76A06DEBF1A5096512CD132D697E8ACB89B (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_spatializePostEffects_m7030C76A06DEBF1A5096512CD132D697E8ACB89B_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_spatializePostEffects_m7030C76A06DEBF1A5096512CD132D697E8ACB89B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_spatializePostEffects_m7030C76A06DEBF1A5096512CD132D697E8ACB89B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_spatializePostEffects(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.AudioSource::SetCustomCurve(UnityEngine.AudioSourceCurveType,UnityEngine.AnimationCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_SetCustomCurve_m2116803AB60CE22B9FD98B83D40F954D7A246C69 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___type0, AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * ___curve1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___type0;
		AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * L_1 = ___curve1;
		AudioSource_SetCustomCurveHelper_mB444ACB3E7BF771A4E724310A44669D5F1236C23(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.AnimationCurve UnityEngine.AudioSource::GetCustomCurve(UnityEngine.AudioSourceCurveType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * AudioSource_GetCustomCurve_m6D153D5085C5CC2C2502A1A6B41EB33B04A4E144 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___type0, const RuntimeMethod* method)
{
	AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * V_0 = NULL;
	{
		int32_t L_0 = ___type0;
		AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * L_1 = AudioSource_GetCustomCurveHelper_m0D5A8403CAC89257DF8ACD15C514A5DE621BF749(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		AnimationCurve_tD2F265379583AAF1BF8D84F1BB8DB12980FA504C * L_2 = V_0;
		return L_2;
	}
}
// System.Single UnityEngine.AudioSource::get_reverbZoneMix()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_reverbZoneMix_m7C3DD9F908BB0D48F6F1A29FD7A354C5542F111A (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_reverbZoneMix_m7C3DD9F908BB0D48F6F1A29FD7A354C5542F111A_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_reverbZoneMix_m7C3DD9F908BB0D48F6F1A29FD7A354C5542F111A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_reverbZoneMix_m7C3DD9F908BB0D48F6F1A29FD7A354C5542F111A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_reverbZoneMix()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_reverbZoneMix(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_reverbZoneMix_mF004D7B799EC7EDB38E5069A004A4C0C509DCB87 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_reverbZoneMix_mF004D7B799EC7EDB38E5069A004A4C0C509DCB87_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_reverbZoneMix_mF004D7B799EC7EDB38E5069A004A4C0C509DCB87_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_reverbZoneMix_mF004D7B799EC7EDB38E5069A004A4C0C509DCB87_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_reverbZoneMix(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_bypassEffects()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_bypassEffects_m611C4D7600941291B1AB76069BA9EA1F13D8B589 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_bypassEffects_m611C4D7600941291B1AB76069BA9EA1F13D8B589_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_bypassEffects_m611C4D7600941291B1AB76069BA9EA1F13D8B589_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_bypassEffects_m611C4D7600941291B1AB76069BA9EA1F13D8B589_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_bypassEffects()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_bypassEffects(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_bypassEffects_m6E1BBD3084EEEA68DDD468C8D488DC85A1112AD3 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_bypassEffects_m6E1BBD3084EEEA68DDD468C8D488DC85A1112AD3_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_bypassEffects_m6E1BBD3084EEEA68DDD468C8D488DC85A1112AD3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_bypassEffects_m6E1BBD3084EEEA68DDD468C8D488DC85A1112AD3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_bypassEffects(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_bypassListenerEffects()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_bypassListenerEffects_m52C8B5B45ED4D909A2A6FE7C6D1382AAE3CE1A10 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_bypassListenerEffects_m52C8B5B45ED4D909A2A6FE7C6D1382AAE3CE1A10_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_bypassListenerEffects_m52C8B5B45ED4D909A2A6FE7C6D1382AAE3CE1A10_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_bypassListenerEffects_m52C8B5B45ED4D909A2A6FE7C6D1382AAE3CE1A10_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_bypassListenerEffects()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_bypassListenerEffects(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_bypassListenerEffects_m34B3031437F9BC2D8A99584B4906DD23FC73A16C (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_bypassListenerEffects_m34B3031437F9BC2D8A99584B4906DD23FC73A16C_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_bypassListenerEffects_m34B3031437F9BC2D8A99584B4906DD23FC73A16C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_bypassListenerEffects_m34B3031437F9BC2D8A99584B4906DD23FC73A16C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_bypassListenerEffects(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_bypassReverbZones()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_bypassReverbZones_m0022B61400FD43C234B35D5720545B8FD608D3C2 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_bypassReverbZones_m0022B61400FD43C234B35D5720545B8FD608D3C2_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_bypassReverbZones_m0022B61400FD43C234B35D5720545B8FD608D3C2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_bypassReverbZones_m0022B61400FD43C234B35D5720545B8FD608D3C2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_bypassReverbZones()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_bypassReverbZones(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_bypassReverbZones_m05084DBBFD9B2E7375DFA9573692D159579BE4AE (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_bypassReverbZones_m05084DBBFD9B2E7375DFA9573692D159579BE4AE_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_bypassReverbZones_m05084DBBFD9B2E7375DFA9573692D159579BE4AE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_bypassReverbZones_m05084DBBFD9B2E7375DFA9573692D159579BE4AE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_bypassReverbZones(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_dopplerLevel()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_dopplerLevel_mE282667E115B2372A3163EC9C9DF9BA69EEEC6EB (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_dopplerLevel_mE282667E115B2372A3163EC9C9DF9BA69EEEC6EB_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_dopplerLevel_mE282667E115B2372A3163EC9C9DF9BA69EEEC6EB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_dopplerLevel_mE282667E115B2372A3163EC9C9DF9BA69EEEC6EB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_dopplerLevel()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_dopplerLevel(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_dopplerLevel_mA90937913103AB595C891B72B4B5724F8F54AB86 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_dopplerLevel_mA90937913103AB595C891B72B4B5724F8F54AB86_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_dopplerLevel_mA90937913103AB595C891B72B4B5724F8F54AB86_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_dopplerLevel_mA90937913103AB595C891B72B4B5724F8F54AB86_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_dopplerLevel(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_spread()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_spread_m35E2B95E4DB64DE94037272C7DCD2434CD928606 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_spread_m35E2B95E4DB64DE94037272C7DCD2434CD928606_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_spread_m35E2B95E4DB64DE94037272C7DCD2434CD928606_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_spread_m35E2B95E4DB64DE94037272C7DCD2434CD928606_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_spread()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_spread(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spread_m511F99128902DF9745AD5337D79E3D43E2BE3DBF (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_spread_m511F99128902DF9745AD5337D79E3D43E2BE3DBF_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_spread_m511F99128902DF9745AD5337D79E3D43E2BE3DBF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_spread_m511F99128902DF9745AD5337D79E3D43E2BE3DBF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_spread(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Int32 UnityEngine.AudioSource::get_priority()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioSource_get_priority_m70CCC4BDAB1356902112C27B0C1BADAB23882077 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioSource_get_priority_m70CCC4BDAB1356902112C27B0C1BADAB23882077_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_priority_m70CCC4BDAB1356902112C27B0C1BADAB23882077_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_priority_m70CCC4BDAB1356902112C27B0C1BADAB23882077_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_priority()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_priority(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_priority_m2560D32385E544B7706071B38F2A195C72E50AB6 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_priority_m2560D32385E544B7706071B38F2A195C72E50AB6_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t);
	static AudioSource_set_priority_m2560D32385E544B7706071B38F2A195C72E50AB6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_priority_m2560D32385E544B7706071B38F2A195C72E50AB6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_priority(System.Int32)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AudioSource::get_mute()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_get_mute_mC420E7827CA751603A85430D849E8C3099FBD123 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_get_mute_mC420E7827CA751603A85430D849E8C3099FBD123_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_mute_mC420E7827CA751603A85430D849E8C3099FBD123_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_mute_mC420E7827CA751603A85430D849E8C3099FBD123_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_mute()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_mute(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_mute_m04D579849D7D37D6CC39DE31DB928176B2A9C2CF (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_mute_m04D579849D7D37D6CC39DE31DB928176B2A9C2CF_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, bool);
	static AudioSource_set_mute_m04D579849D7D37D6CC39DE31DB928176B2A9C2CF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_mute_m04D579849D7D37D6CC39DE31DB928176B2A9C2CF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_mute(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_minDistance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_minDistance_m5CC7E0BF063CE86D4A6B2D4C9D084ADC98B66081 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_minDistance_m5CC7E0BF063CE86D4A6B2D4C9D084ADC98B66081_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_minDistance_m5CC7E0BF063CE86D4A6B2D4C9D084ADC98B66081_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_minDistance_m5CC7E0BF063CE86D4A6B2D4C9D084ADC98B66081_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_minDistance()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_minDistance(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_minDistance_m6BE1B716538D146E7DAFED645624204A6F49496C (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_minDistance_m6BE1B716538D146E7DAFED645624204A6F49496C_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_minDistance_m6BE1B716538D146E7DAFED645624204A6F49496C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_minDistance_m6BE1B716538D146E7DAFED645624204A6F49496C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_minDistance(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.AudioSource::get_maxDistance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_maxDistance_m6CF9ECA5BE401525C918357FC56FDC03D9EA7742 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef float (*AudioSource_get_maxDistance_m6CF9ECA5BE401525C918357FC56FDC03D9EA7742_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_maxDistance_m6CF9ECA5BE401525C918357FC56FDC03D9EA7742_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_maxDistance_m6CF9ECA5BE401525C918357FC56FDC03D9EA7742_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_maxDistance()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_maxDistance(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_maxDistance_m28ACA41DEC146D471E3E5EC0CC4EC2013D46F5E0 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_maxDistance_m28ACA41DEC146D471E3E5EC0CC4EC2013D46F5E0_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, float);
	static AudioSource_set_maxDistance_m28ACA41DEC146D471E3E5EC0CC4EC2013D46F5E0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_maxDistance_m28ACA41DEC146D471E3E5EC0CC4EC2013D46F5E0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_maxDistance(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.AudioRolloffMode UnityEngine.AudioSource::get_rolloffMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AudioSource_get_rolloffMode_m1AD680EF7696C27D41845EEDA0B0B5ED2EBCD5A7 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AudioSource_get_rolloffMode_m1AD680EF7696C27D41845EEDA0B0B5ED2EBCD5A7_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *);
	static AudioSource_get_rolloffMode_m1AD680EF7696C27D41845EEDA0B0B5ED2EBCD5A7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_get_rolloffMode_m1AD680EF7696C27D41845EEDA0B0B5ED2EBCD5A7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::get_rolloffMode()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.AudioSource::set_rolloffMode(UnityEngine.AudioRolloffMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_rolloffMode_m1E420E7DC5D44A0001A22352C1CD59BEAED1794D (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*AudioSource_set_rolloffMode_m1E420E7DC5D44A0001A22352C1CD59BEAED1794D_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t);
	static AudioSource_set_rolloffMode_m1E420E7DC5D44A0001A22352C1CD59BEAED1794D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_set_rolloffMode_m1E420E7DC5D44A0001A22352C1CD59BEAED1794D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::set_rolloffMode(UnityEngine.AudioRolloffMode)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single[] UnityEngine.AudioSource::GetOutputData(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* AudioSource_GetOutputData_m0F928FDD4525BCC40ABE7D4B3CE93E505E604409 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___numSamples0, int32_t ___channel1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_GetOutputData_m0F928FDD4525BCC40ABE7D4B3CE93E505E604409_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* V_0 = NULL;
	SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* V_1 = NULL;
	{
		int32_t L_0 = ___numSamples0;
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_1 = (SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*)(SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*)SZArrayNew(SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5_il2cpp_TypeInfo_var, (uint32_t)L_0);
		V_0 = L_1;
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_2 = V_0;
		int32_t L_3 = ___channel1;
		AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801(__this, L_2, L_3, /*hidden argument*/NULL);
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_4 = V_0;
		V_1 = L_4;
		goto IL_0015;
	}

IL_0015:
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_5 = V_1;
		return L_5;
	}
}
// System.Void UnityEngine.AudioSource::GetOutputData(System.Single[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_GetOutputData_m511EDCF58BF1BECAC6E562963C33A66FFC81052E (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___samples0, int32_t ___channel1, const RuntimeMethod* method)
{
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_0 = ___samples0;
		int32_t L_1 = ___channel1;
		AudioSource_GetOutputDataHelper_mA154C4E224C07DCEF2759CB27FE4C5B63EE0C801(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Single[] UnityEngine.AudioSource::GetSpectrumData(System.Int32,System.Int32,UnityEngine.FFTWindow)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* AudioSource_GetSpectrumData_m58D07A34603F25DD1A648EE8BFE55D9F1A6C0C25 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___numSamples0, int32_t ___channel1, int32_t ___window2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_GetSpectrumData_m58D07A34603F25DD1A648EE8BFE55D9F1A6C0C25_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* V_0 = NULL;
	SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* V_1 = NULL;
	{
		int32_t L_0 = ___numSamples0;
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_1 = (SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*)(SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5*)SZArrayNew(SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5_il2cpp_TypeInfo_var, (uint32_t)L_0);
		V_0 = L_1;
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_2 = V_0;
		int32_t L_3 = ___channel1;
		int32_t L_4 = ___window2;
		AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2(__this, L_2, L_3, L_4, /*hidden argument*/NULL);
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_5 = V_0;
		V_1 = L_5;
		goto IL_0016;
	}

IL_0016:
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_6 = V_1;
		return L_6;
	}
}
// System.Void UnityEngine.AudioSource::GetSpectrumData(System.Single[],System.Int32,UnityEngine.FFTWindow)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_GetSpectrumData_m7FE189F755226A6DEE06A7524F20E6209B60A39A (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___samples0, int32_t ___channel1, int32_t ___window2, const RuntimeMethod* method)
{
	{
		SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* L_0 = ___samples0;
		int32_t L_1 = ___channel1;
		int32_t L_2 = ___window2;
		AudioSource_GetSpectrumDataHelper_m992127D807310716E133343D46274B98853123D2(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.AudioSource::get_minVolume()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_minVolume_m8A959E5FE81FEBEEA09C6A693AC753E030B3BD2A (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_get_minVolume_m8A959E5FE81FEBEEA09C6A693AC753E030B3BD2A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29(_stringLiteral31C244D856B46A8D9797F64184021411F8D1A054, /*hidden argument*/NULL);
		V_0 = (0.0f);
		goto IL_0014;
	}

IL_0014:
	{
		float L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.AudioSource::set_minVolume(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_minVolume_mC541C9D353B51A55845840038EC13A48B2361523 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_set_minVolume_mC541C9D353B51A55845840038EC13A48B2361523_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29(_stringLiteral31C244D856B46A8D9797F64184021411F8D1A054, /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.AudioSource::get_maxVolume()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_maxVolume_m062A75A13F618E5614614AA0E7801996D311988D (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_get_maxVolume_m062A75A13F618E5614614AA0E7801996D311988D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29(_stringLiteralE8A96C404AB746F16F0578617B5A0B2B1011BF64, /*hidden argument*/NULL);
		V_0 = (0.0f);
		goto IL_0014;
	}

IL_0014:
	{
		float L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.AudioSource::set_maxVolume(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_maxVolume_m4536FB7CBB5A2B8CA1EE64D97FECD241569634F1 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_set_maxVolume_m4536FB7CBB5A2B8CA1EE64D97FECD241569634F1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29(_stringLiteralE8A96C404AB746F16F0578617B5A0B2B1011BF64, /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.AudioSource::get_rolloffFactor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_rolloffFactor_mB207AAF2085DE7C1DE380A9A8FB825E78303E753 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_get_rolloffFactor_mB207AAF2085DE7C1DE380A9A8FB825E78303E753_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29(_stringLiteral2C64ADC2791F15C91AD9F9389A373F05AA662698, /*hidden argument*/NULL);
		V_0 = (0.0f);
		goto IL_0014;
	}

IL_0014:
	{
		float L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.AudioSource::set_rolloffFactor(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_rolloffFactor_m357716D5400492671031FB94EB39AAB4569AF24C (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, float ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AudioSource_set_rolloffFactor_m357716D5400492671031FB94EB39AAB4569AF24C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t7B5FCB117E2FD63B6838BC52821B252E2BFB61C4_il2cpp_TypeInfo_var);
		Debug_LogError_m3BCF9B78263152261565DCA9DB7D55F0C391ED29(_stringLiteral2C64ADC2791F15C91AD9F9389A373F05AA662698, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.AudioSource::SetSpatializerFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_SetSpatializerFloat_mA34E8E88A05FF3682B00E1D29D80581AFED8098F (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_SetSpatializerFloat_mA34E8E88A05FF3682B00E1D29D80581AFED8098F_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t, float);
	static AudioSource_SetSpatializerFloat_mA34E8E88A05FF3682B00E1D29D80581AFED8098F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_SetSpatializerFloat_mA34E8E88A05FF3682B00E1D29D80581AFED8098F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::SetSpatializerFloat(System.Int32,System.Single)");
	bool retVal = _il2cpp_icall_func(__this, ___index0, ___value1);
	return retVal;
}
// System.Boolean UnityEngine.AudioSource::GetSpatializerFloat(System.Int32,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_GetSpatializerFloat_m47FA25D5590DEB638146B3B2A90ECD082B249D81 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___index0, float* ___value1, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_GetSpatializerFloat_m47FA25D5590DEB638146B3B2A90ECD082B249D81_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t, float*);
	static AudioSource_GetSpatializerFloat_m47FA25D5590DEB638146B3B2A90ECD082B249D81_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_GetSpatializerFloat_m47FA25D5590DEB638146B3B2A90ECD082B249D81_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::GetSpatializerFloat(System.Int32,System.Single&)");
	bool retVal = _il2cpp_icall_func(__this, ___index0, ___value1);
	return retVal;
}
// System.Boolean UnityEngine.AudioSource::GetAmbisonicDecoderFloat(System.Int32,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_GetAmbisonicDecoderFloat_mC2CCC987BF33DF788AAFDA36FF24C72FE69EE33D (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___index0, float* ___value1, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_GetAmbisonicDecoderFloat_mC2CCC987BF33DF788AAFDA36FF24C72FE69EE33D_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t, float*);
	static AudioSource_GetAmbisonicDecoderFloat_mC2CCC987BF33DF788AAFDA36FF24C72FE69EE33D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_GetAmbisonicDecoderFloat_mC2CCC987BF33DF788AAFDA36FF24C72FE69EE33D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::GetAmbisonicDecoderFloat(System.Int32,System.Single&)");
	bool retVal = _il2cpp_icall_func(__this, ___index0, ___value1);
	return retVal;
}
// System.Boolean UnityEngine.AudioSource::SetAmbisonicDecoderFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AudioSource_SetAmbisonicDecoderFloat_mE04D738825362140D90E7F2C8793C590CF76288A (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	typedef bool (*AudioSource_SetAmbisonicDecoderFloat_mE04D738825362140D90E7F2C8793C590CF76288A_ftn) (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C *, int32_t, float);
	static AudioSource_SetAmbisonicDecoderFloat_mE04D738825362140D90E7F2C8793C590CF76288A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AudioSource_SetAmbisonicDecoderFloat_mE04D738825362140D90E7F2C8793C590CF76288A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AudioSource::SetAmbisonicDecoderFloat(System.Int32,System.Single)");
	bool retVal = _il2cpp_icall_func(__this, ___index0, ___value1);
	return retVal;
}
// System.Void UnityEngine.AudioSource::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource__ctor_m16DE45CD7FEFDEDC97B279769B399D0F995F7299 (AudioSource_t5196F862B4E60F404613361C90D87FBDD041E93C * __this, const RuntimeMethod* method)
{
	{
		AudioBehaviour__ctor_m43B1C08196D937549E20DE6370263646C1D81F59(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Experimental.Audio.AudioSampleProvider::InvokeSampleFramesAvailable(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSampleProvider_InvokeSampleFramesAvailable_m7604AAF1AC01473A29DCDAD1AEC06165504BE832 (AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 * __this, int32_t ___sampleFrameCount0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * L_0 = __this->get_sampleFramesAvailable_0();
		V_0 = (bool)((!(((RuntimeObject*)(SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001c;
		}
	}
	{
		SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * L_2 = __this->get_sampleFramesAvailable_0();
		int32_t L_3 = ___sampleFrameCount0;
		NullCheck(L_2);
		SampleFramesHandler_Invoke_m52F0148F680B36E04A7F850E617FBEF1CA9809FD(L_2, __this, L_3, /*hidden argument*/NULL);
	}

IL_001c:
	{
		return;
	}
}
// System.Void UnityEngine.Experimental.Audio.AudioSampleProvider::InvokeSampleFramesOverflow(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSampleProvider_InvokeSampleFramesOverflow_mC81A014388E535569EF02E3DA6B9831B0FB8A8D4 (AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 * __this, int32_t ___droppedSampleFrameCount0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * L_0 = __this->get_sampleFramesOverflow_1();
		V_0 = (bool)((!(((RuntimeObject*)(SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001c;
		}
	}
	{
		SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * L_2 = __this->get_sampleFramesOverflow_1();
		int32_t L_3 = ___droppedSampleFrameCount0;
		NullCheck(L_2);
		SampleFramesHandler_Invoke_m52F0148F680B36E04A7F850E617FBEF1CA9809FD(L_2, __this, L_3, /*hidden argument*/NULL);
	}

IL_001c:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleFramesHandler__ctor_mFDA0769E55F136D1B8EC8AA4B40EF43069934EB5 (SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler::Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleFramesHandler_Invoke_m52F0148F680B36E04A7F850E617FBEF1CA9809FD (SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * __this, AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 * ___provider0, uint32_t ___sampleFrameCount1, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 2)
			{
				// open
				typedef void (*FunctionPointerType) (AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___provider0, ___sampleFrameCount1, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___provider0, ___sampleFrameCount1, targetMethod);
			}
		}
		else if (___parameterCount != 2)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< uint32_t >::Invoke(targetMethod, ___provider0, ___sampleFrameCount1);
					else
						GenericVirtActionInvoker1< uint32_t >::Invoke(targetMethod, ___provider0, ___sampleFrameCount1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< uint32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___provider0, ___sampleFrameCount1);
					else
						VirtActionInvoker1< uint32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___provider0, ___sampleFrameCount1);
				}
			}
			else
			{
				if (targetThis == NULL && il2cpp_codegen_class_is_value_type(il2cpp_codegen_method_get_declaring_type(targetMethod)))
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((reinterpret_cast<RuntimeObject*>(&___sampleFrameCount1) - 1), targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___provider0, ___sampleFrameCount1, targetMethod);
				}
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___provider0, ___sampleFrameCount1, targetMethod);
				}
				else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker2< AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t >::Invoke(targetMethod, targetThis, ___provider0, ___sampleFrameCount1);
					else
						GenericVirtActionInvoker2< AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t >::Invoke(targetMethod, targetThis, ___provider0, ___sampleFrameCount1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker2< AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___provider0, ___sampleFrameCount1);
					else
						VirtActionInvoker2< AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___provider0, ___sampleFrameCount1);
				}
			}
			else
			{
				if (targetThis == NULL && il2cpp_codegen_class_is_value_type(il2cpp_codegen_method_get_declaring_type(targetMethod)))
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, uint32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((reinterpret_cast<RuntimeObject*>(___provider0) - 1), ___sampleFrameCount1, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 *, uint32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___provider0, ___sampleFrameCount1, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler::BeginInvoke(UnityEngine.Experimental.Audio.AudioSampleProvider,System.UInt32,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SampleFramesHandler_BeginInvoke_mE516B77CCC50738663D10DDD2D7BDB4391FDFF92 (SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * __this, AudioSampleProvider_tD5B209D07C5F1D4714F92069F4071068B9BC6913 * ___provider0, uint32_t ___sampleFrameCount1, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SampleFramesHandler_BeginInvoke_mE516B77CCC50738663D10DDD2D7BDB4391FDFF92_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = ___provider0;
	__d_args[1] = Box(UInt32_t4980FA09003AFAAB5A6E361BA2748EA9A005709B_il2cpp_TypeInfo_var, &___sampleFrameCount1);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);
}
// System.Void UnityEngine.Experimental.Audio.AudioSampleProvider_SampleFramesHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SampleFramesHandler_EndInvoke_mF5305B3BA179CE3C49836790DE3FEB02EB088D28 (SampleFramesHandler_t5179C92AFBB393A85144E9134A862C161726F6AF * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif

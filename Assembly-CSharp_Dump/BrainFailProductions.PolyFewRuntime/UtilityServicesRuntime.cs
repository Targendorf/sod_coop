using System;
using System.Runtime.CompilerServices;
using BrainFailProductions.PolyFew.AsImpL;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace BrainFailProductions.PolyFewRuntime;

public class UtilityServicesRuntime : MonoBehaviour
{
	public class OBJExporterImporter : Il2CppSystem.Object
	{
		[ObfuscatedName("BrainFailProductions.PolyFewRuntime.UtilityServicesRuntime+OBJExporterImporter+<ExportMeshToOBJ>d__15")]
		public sealed class _ExportMeshToOBJ_d__15 : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

			private static readonly System.IntPtr NativeFieldInfoPtr_exportPath;

			private static readonly System.IntPtr NativeFieldInfoPtr__objectName_5__2;

			private static readonly System.IntPtr NativeFieldInfoPtr__sb_5__3;

			private static readonly System.IntPtr NativeFieldInfoPtr__lastIndex_5__4;

			private static readonly System.IntPtr NativeFieldInfoPtr__faceOrder_5__5;

			private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap5;

			private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap6;

			private static readonly System.IntPtr NativeFieldInfoPtr__vx_5__8;

			private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

			private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap8;

			private static readonly System.IntPtr NativeFieldInfoPtr__v_5__10;

			private static readonly System.IntPtr NativeFieldInfoPtr__tris_5__11;

			private static readonly System.IntPtr NativeFieldInfoPtr__t_5__12;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

			public unsafe int __1__state
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
					return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe OBJExporterImporter __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OBJExporterImporter>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oBJExporterImporter));
				}
			}

			public unsafe Mesh mesh
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
				}
			}

			public unsafe string exportPath
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exportPath);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exportPath)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string _objectName_5__2
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectName_5__2);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectName_5__2)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe StringBuilder _sb_5__3
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sb_5__3);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sb_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringBuilder));
				}
			}

			public unsafe int _lastIndex_5__4
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastIndex_5__4);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastIndex_5__4)) = num;
				}
			}

			public unsafe int _faceOrder_5__5
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__faceOrder_5__5);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__faceOrder_5__5)) = num;
				}
			}

			public unsafe Il2CppStructArray<Vector3> __7__wrap5
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap5);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap5)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
				}
			}

			public unsafe int __7__wrap6
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap6);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap6)) = num;
				}
			}

			public unsafe Vector3 _vx_5__8
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__vx_5__8);
					return *(Vector3*)num;
				}
				set
				{
					*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__vx_5__8)) = vector;
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
					return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe Il2CppStructArray<Vector2> __7__wrap8
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap8);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap8)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
				}
			}

			public unsafe Vector2 _v_5__10
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__v_5__10);
					return *(Vector2*)num;
				}
				set
				{
					*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__v_5__10)) = vector;
				}
			}

			public unsafe Il2CppStructArray<int> _tris_5__11
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tris_5__11);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tris_5__11)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
				}
			}

			public unsafe int _t_5__12
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__t_5__12);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__t_5__12)) = num;
				}
			}

			static _ExportMeshToOBJ_d__15()
			{
				Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "<ExportMeshToOBJ>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr);
				NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>1__state");
				NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>t__builder");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>4__this");
				NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "mesh");
				NativeFieldInfoPtr_exportPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "exportPath");
				NativeFieldInfoPtr__objectName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<objectName>5__2");
				NativeFieldInfoPtr__sb_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<sb>5__3");
				NativeFieldInfoPtr__lastIndex_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<lastIndex>5__4");
				NativeFieldInfoPtr__faceOrder_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<faceOrder>5__5");
				NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>7__wrap5");
				NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>7__wrap6");
				NativeFieldInfoPtr__vx_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<vx>5__8");
				NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>u__1");
				NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<>7__wrap8");
				NativeFieldInfoPtr__v_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<v>5__10");
				NativeFieldInfoPtr__tris_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<tris>5__11");
				NativeFieldInfoPtr__t_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, "<t>5__12");
				NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, 100677445);
				NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr, 100677446);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379324, XrefRangeEnd = 379584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379584, XrefRangeEnd = 379588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public _ExportMeshToOBJ_d__15(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public _ExportMeshToOBJ_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ExportMeshToOBJ_d__15>.NativeClassPtr))
			{
			}
		}

		[ObfuscatedName("BrainFailProductions.PolyFewRuntime.UtilityServicesRuntime+OBJExporterImporter+<ImportFromLocalFileSystem>d__20")]
		public sealed class _ImportFromLocalFileSystem_d__20 : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

			private static readonly System.IntPtr NativeFieldInfoPtr_objPath;

			private static readonly System.IntPtr NativeFieldInfoPtr_texturesFolderPath;

			private static readonly System.IntPtr NativeFieldInfoPtr_materialsFolderPath;

			private static readonly System.IntPtr NativeFieldInfoPtr_importOptions;

			private static readonly System.IntPtr NativeFieldInfoPtr_Callback;

			private static readonly System.IntPtr NativeFieldInfoPtr__objectToPopulate_5__2;

			private static readonly System.IntPtr NativeFieldInfoPtr__objImporter_5__3;

			private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

			public unsafe int __1__state
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
					return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe string objPath
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objPath);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objPath)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string texturesFolderPath
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texturesFolderPath);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texturesFolderPath)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string materialsFolderPath
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsFolderPath);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsFolderPath)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe PolyfewRuntime.OBJImportOptions importOptions
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importOptions);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PolyfewRuntime.OBJImportOptions>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oBJImportOptions));
				}
			}

			public unsafe Il2CppSystem.Action<GameObject> Callback
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Callback);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe GameObject _objectToPopulate_5__2
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectToPopulate_5__2);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectToPopulate_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
				}
			}

			public unsafe ObjectImporter _objImporter_5__3
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objImporter_5__3);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectImporter>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objImporter_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectImporter));
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject> __u__1
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
					return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			static _ImportFromLocalFileSystem_d__20()
			{
				Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "<ImportFromLocalFileSystem>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr);
				NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "<>1__state");
				NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "<>t__builder");
				NativeFieldInfoPtr_objPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "objPath");
				NativeFieldInfoPtr_texturesFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "texturesFolderPath");
				NativeFieldInfoPtr_materialsFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "materialsFolderPath");
				NativeFieldInfoPtr_importOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "importOptions");
				NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "Callback");
				NativeFieldInfoPtr__objectToPopulate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "<objectToPopulate>5__2");
				NativeFieldInfoPtr__objImporter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "<objImporter>5__3");
				NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, "<>u__1");
				NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, 100677447);
				NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr, 100677448);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379588, XrefRangeEnd = 379699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379699, XrefRangeEnd = 379707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public _ImportFromLocalFileSystem_d__20(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public _ImportFromLocalFileSystem_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ImportFromLocalFileSystem_d__20>.NativeClassPtr))
			{
			}
		}

		[ObfuscatedName("BrainFailProductions.PolyFewRuntime.UtilityServicesRuntime+OBJExporterImporter+<ImportFromNetwork>d__21")]
		public sealed class _ImportFromNetwork_d__21 : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

			private static readonly System.IntPtr NativeFieldInfoPtr_objURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_diffuseTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_materialURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_downloadProgress;

			private static readonly System.IntPtr NativeFieldInfoPtr_importOptions;

			private static readonly System.IntPtr NativeFieldInfoPtr_objName;

			private static readonly System.IntPtr NativeFieldInfoPtr_bumpTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_specularTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_opacityTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_OnSuccess;

			private static readonly System.IntPtr NativeFieldInfoPtr_OnError;

			private static readonly System.IntPtr NativeFieldInfoPtr__objectToPopulate_5__2;

			private static readonly System.IntPtr NativeFieldInfoPtr__objImporter_5__3;

			private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

			public unsafe int __1__state
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
					return new Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncVoidMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe string objURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string diffuseTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string materialURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe PolyfewRuntime.ReferencedNumeric<float> downloadProgress
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downloadProgress);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PolyfewRuntime.ReferencedNumeric<float>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downloadProgress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)referencedNumeric));
				}
			}

			public unsafe PolyfewRuntime.OBJImportOptions importOptions
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importOptions);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PolyfewRuntime.OBJImportOptions>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oBJImportOptions));
				}
			}

			public unsafe string objName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objName)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string bumpTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string specularTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string opacityTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe Il2CppSystem.Action<GameObject> OnSuccess
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuccess);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe Il2CppSystem.Action<Il2CppSystem.Exception> OnError
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnError);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppSystem.Exception>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnError)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe GameObject _objectToPopulate_5__2
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectToPopulate_5__2);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectToPopulate_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
				}
			}

			public unsafe ObjectImporter _objImporter_5__3
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objImporter_5__3);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectImporter>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objImporter_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectImporter));
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject> __u__1
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
					return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<GameObject>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			static _ImportFromNetwork_d__21()
			{
				Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "<ImportFromNetwork>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr);
				NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "<>1__state");
				NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "<>t__builder");
				NativeFieldInfoPtr_objURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "objURL");
				NativeFieldInfoPtr_diffuseTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "diffuseTexURL");
				NativeFieldInfoPtr_materialURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "materialURL");
				NativeFieldInfoPtr_downloadProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "downloadProgress");
				NativeFieldInfoPtr_importOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "importOptions");
				NativeFieldInfoPtr_objName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "objName");
				NativeFieldInfoPtr_bumpTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "bumpTexURL");
				NativeFieldInfoPtr_specularTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "specularTexURL");
				NativeFieldInfoPtr_opacityTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "opacityTexURL");
				NativeFieldInfoPtr_OnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "OnSuccess");
				NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "OnError");
				NativeFieldInfoPtr__objectToPopulate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "<objectToPopulate>5__2");
				NativeFieldInfoPtr__objImporter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "<objImporter>5__3");
				NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, "<>u__1");
				NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, 100677449);
				NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr, 100677450);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379707, XrefRangeEnd = 379762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public _ImportFromNetwork_d__21(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public _ImportFromNetwork_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ImportFromNetwork_d__21>.NativeClassPtr))
			{
			}
		}

		[ObfuscatedName("BrainFailProductions.PolyFewRuntime.UtilityServicesRuntime+OBJExporterImporter+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_objImporter;

			private static readonly System.IntPtr NativeFieldInfoPtr_OnSuccess;

			private static readonly System.IntPtr NativeFieldInfoPtr_objectToPopulate;

			private static readonly System.IntPtr NativeFieldInfoPtr_OnError;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ImportFromNetworkWebGL_b__0_Internal_Void_GameObject_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ImportFromNetworkWebGL_b__1_Internal_Void_Exception_0;

			public unsafe ObjectImporter objImporter
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objImporter);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectImporter>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objImporter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectImporter));
				}
			}

			public unsafe Il2CppSystem.Action<GameObject> OnSuccess
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuccess);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe GameObject objectToPopulate
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectToPopulate);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectToPopulate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
				}
			}

			public unsafe Il2CppSystem.Action<Il2CppSystem.Exception> OnError
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnError);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppSystem.Exception>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnError)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr);
				NativeFieldInfoPtr_objImporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, "objImporter");
				NativeFieldInfoPtr_OnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, "OnSuccess");
				NativeFieldInfoPtr_objectToPopulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, "objectToPopulate");
				NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, "OnError");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, 100677451);
				NativeMethodInfoPtr__ImportFromNetworkWebGL_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, 100677452);
				NativeMethodInfoPtr__ImportFromNetworkWebGL_b__1_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, 100677453);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379762, XrefRangeEnd = 379767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ImportFromNetworkWebGL_b__0(GameObject imported)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imported);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ImportFromNetworkWebGL_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379767, XrefRangeEnd = 379772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ImportFromNetworkWebGL_b__1(Il2CppSystem.Exception exception)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ImportFromNetworkWebGL_b__1_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public __c__DisplayClass22_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("BrainFailProductions.PolyFewRuntime.UtilityServicesRuntime+OBJExporterImporter+<ImportFromNetworkWebGL>d__22")]
		public sealed class _ImportFromNetworkWebGL_d__22 : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

			private static readonly System.IntPtr NativeFieldInfoPtr_OnSuccess;

			private static readonly System.IntPtr NativeFieldInfoPtr_OnError;

			private static readonly System.IntPtr NativeFieldInfoPtr_objURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_diffuseTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_materialURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_downloadProgress;

			private static readonly System.IntPtr NativeFieldInfoPtr_importOptions;

			private static readonly System.IntPtr NativeFieldInfoPtr_objName;

			private static readonly System.IntPtr NativeFieldInfoPtr_bumpTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_specularTexURL;

			private static readonly System.IntPtr NativeFieldInfoPtr_opacityTexURL;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

			public unsafe int __1__state
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
				}
			}

			public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
					return new Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncVoidMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe Il2CppSystem.Action<GameObject> OnSuccess
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuccess);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe Il2CppSystem.Action<Il2CppSystem.Exception> OnError
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnError);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppSystem.Exception>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnError)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe string objURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string diffuseTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string materialURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe PolyfewRuntime.ReferencedNumeric<float> downloadProgress
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downloadProgress);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PolyfewRuntime.ReferencedNumeric<float>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downloadProgress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)referencedNumeric));
				}
			}

			public unsafe PolyfewRuntime.OBJImportOptions importOptions
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importOptions);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PolyfewRuntime.OBJImportOptions>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oBJImportOptions));
				}
			}

			public unsafe string objName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objName)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string bumpTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string specularTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string opacityTexURL
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTexURL);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTexURL)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static _ImportFromNetworkWebGL_d__22()
			{
				Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "<ImportFromNetworkWebGL>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr);
				NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "<>1__state");
				NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "<>t__builder");
				NativeFieldInfoPtr_OnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "OnSuccess");
				NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "OnError");
				NativeFieldInfoPtr_objURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "objURL");
				NativeFieldInfoPtr_diffuseTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "diffuseTexURL");
				NativeFieldInfoPtr_materialURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "materialURL");
				NativeFieldInfoPtr_downloadProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "downloadProgress");
				NativeFieldInfoPtr_importOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "importOptions");
				NativeFieldInfoPtr_objName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "objName");
				NativeFieldInfoPtr_bumpTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "bumpTexURL");
				NativeFieldInfoPtr_specularTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "specularTexURL");
				NativeFieldInfoPtr_opacityTexURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, "opacityTexURL");
				NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, 100677454);
				NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr, 100677455);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379772, XrefRangeEnd = 379834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public _ImportFromNetworkWebGL_d__22(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public _ImportFromNetworkWebGL_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ImportFromNetworkWebGL_d__22>.NativeClassPtr))
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_applyPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_applyRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_applyScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_generateMaterials;

		private static readonly System.IntPtr NativeFieldInfoPtr_exportTextures;

		private static readonly System.IntPtr NativeFieldInfoPtr_exportPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshFilter;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshToExport;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshRenderer;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeExporter_Private_Void_GameObject_String_OBJExportOptions_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeExporter_Private_Void_Mesh_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RotateAroundPoint_Private_Vector3_Vector3_Vector3_Quaternion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyVec3s_Private_Vector3_Vector3_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ExportGameObjectToOBJ_Public_Void_GameObject_String_OBJExportOptions_Action_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ExportMeshToOBJ_Public_Task_Mesh_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryExportTexture_Private_String_String_Material_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ExportTexture_Private_String_Texture2D_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConstructOBJString_Private_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MaterialToString_Private_String_Material_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ImportFromLocalFileSystem_Public_Task_String_String_String_Action_1_GameObject_OBJImportOptions_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ImportFromNetwork_Public_Void_String_String_String_String_String_String_String_ReferencedNumeric_1_Single_Action_1_GameObject_Action_1_Exception_OBJImportOptions_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ImportFromNetworkWebGL_Public_Void_String_String_String_String_String_String_String_ReferencedNumeric_1_Single_Action_1_GameObject_Action_1_Exception_OBJImportOptions_0;

		public unsafe bool applyPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyPosition);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyPosition)) = flag;
			}
		}

		public unsafe bool applyRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyRotation);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyRotation)) = flag;
			}
		}

		public unsafe bool applyScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyScale)) = flag;
			}
		}

		public unsafe bool generateMaterials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateMaterials);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateMaterials)) = flag;
			}
		}

		public unsafe bool exportTextures
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exportTextures);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exportTextures)) = flag;
			}
		}

		public unsafe string exportPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exportPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exportPath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe MeshFilter meshFilter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilter);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshFilter));
			}
		}

		public unsafe Mesh meshToExport
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshToExport);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshToExport)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe MeshRenderer meshRenderer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
			}
		}

		static OBJExporterImporter()
		{
			Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, "OBJExporterImporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr);
			NativeFieldInfoPtr_applyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "applyPosition");
			NativeFieldInfoPtr_applyRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "applyRotation");
			NativeFieldInfoPtr_applyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "applyScale");
			NativeFieldInfoPtr_generateMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "generateMaterials");
			NativeFieldInfoPtr_exportTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "exportTextures");
			NativeFieldInfoPtr_exportPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "exportPath");
			NativeFieldInfoPtr_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "meshFilter");
			NativeFieldInfoPtr_meshToExport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "meshToExport");
			NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, "meshRenderer");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677431);
			NativeMethodInfoPtr_InitializeExporter_Private_Void_GameObject_String_OBJExportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677432);
			NativeMethodInfoPtr_InitializeExporter_Private_Void_Mesh_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677433);
			NativeMethodInfoPtr_RotateAroundPoint_Private_Vector3_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677434);
			NativeMethodInfoPtr_MultiplyVec3s_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677435);
			NativeMethodInfoPtr_ExportGameObjectToOBJ_Public_Void_GameObject_String_OBJExportOptions_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677436);
			NativeMethodInfoPtr_ExportMeshToOBJ_Public_Task_Mesh_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677437);
			NativeMethodInfoPtr_TryExportTexture_Private_String_String_Material_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677438);
			NativeMethodInfoPtr_ExportTexture_Private_String_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677439);
			NativeMethodInfoPtr_ConstructOBJString_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677440);
			NativeMethodInfoPtr_MaterialToString_Private_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677441);
			NativeMethodInfoPtr_ImportFromLocalFileSystem_Public_Task_String_String_String_Action_1_GameObject_OBJImportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677442);
			NativeMethodInfoPtr_ImportFromNetwork_Public_Void_String_String_String_String_String_String_String_ReferencedNumeric_1_Single_Action_1_GameObject_Action_1_Exception_OBJImportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677443);
			NativeMethodInfoPtr_ImportFromNetworkWebGL_Public_Void_String_String_String_String_String_String_String_ReferencedNumeric_1_Single_Action_1_GameObject_Action_1_Exception_OBJImportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr, 100677444);
		}

		[CallerCount(0)]
		public unsafe OBJExporterImporter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OBJExporterImporter>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379900, RefRangeEnd = 379901, XrefRangeStart = 379834, XrefRangeEnd = 379900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeExporter(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toExport);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exportPath);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exportOptions);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeExporter_Private_Void_GameObject_String_OBJExportOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379927, RefRangeEnd = 379928, XrefRangeStart = 379901, XrefRangeEnd = 379927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeExporter(Mesh toExport, string exportPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toExport);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exportPath);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeExporter_Private_Void_Mesh_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379928, RefRangeEnd = 379930, XrefRangeStart = 379928, XrefRangeEnd = 379928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&point);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
			*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateAroundPoint_Private_Vector3_Vector3_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe Vector3 MultiplyVec3s(Vector3 v1, Vector3 v2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&v1);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyVec3s_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380185, RefRangeEnd = 380186, XrefRangeStart = 379930, XrefRangeEnd = 380185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExportGameObjectToOBJ(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions = null, Il2CppSystem.Action OnSuccess = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toExport);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exportPath);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exportOptions);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnSuccess);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportGameObjectToOBJ_Public_Void_GameObject_String_OBJExportOptions_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380186, XrefRangeEnd = 380198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ExportMeshToOBJ(Mesh mesh, string exportPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exportPath);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportMeshToOBJ_Public_Task_Mesh_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380215, RefRangeEnd = 380218, XrefRangeStart = 380198, XrefRangeEnd = 380215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TryExportTexture(string propertyName, Material m, string exportPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exportPath);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryExportTexture_Private_String_String_Material_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380249, RefRangeEnd = 380250, XrefRangeStart = 380218, XrefRangeEnd = 380249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ExportTexture(Texture2D t, string exportPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exportPath);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportTexture_Private_String_Texture2D_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 380281, RefRangeEnd = 380293, XrefRangeStart = 380250, XrefRangeEnd = 380281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConstructOBJString(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructOBJString_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380458, RefRangeEnd = 380459, XrefRangeStart = 380293, XrefRangeEnd = 380458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MaterialToString(Material m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaterialToString_Private_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380471, RefRangeEnd = 380472, XrefRangeStart = 380459, XrefRangeEnd = 380471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ImportFromLocalFileSystem(string objPath, string texturesFolderPath, string materialsFolderPath, Il2CppSystem.Action<GameObject> Callback, PolyfewRuntime.OBJImportOptions importOptions = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objPath);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(texturesFolderPath);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(materialsFolderPath);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)importOptions);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportFromLocalFileSystem_Public_Task_String_String_String_Action_1_GameObject_OBJImportOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380476, RefRangeEnd = 380477, XrefRangeStart = 380472, XrefRangeEnd = 380476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Il2CppSystem.Action<GameObject> OnSuccess, Il2CppSystem.Action<Il2CppSystem.Exception> OnError, PolyfewRuntime.OBJImportOptions importOptions = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(diffuseTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(bumpTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(specularTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(opacityTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(materialURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadProgress);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnSuccess);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnError);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)importOptions);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportFromNetwork_Public_Void_String_String_String_String_String_String_String_ReferencedNumeric_1_Single_Action_1_GameObject_Action_1_Exception_OBJImportOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380477, XrefRangeEnd = 380481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Il2CppSystem.Action<GameObject> OnSuccess, Il2CppSystem.Action<Il2CppSystem.Exception> OnError, PolyfewRuntime.OBJImportOptions importOptions = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(diffuseTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(bumpTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(specularTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(opacityTexURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(materialURL);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadProgress);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnSuccess);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnError);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)importOptions);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportFromNetworkWebGL_Public_Void_String_String_String_String_String_String_String_ReferencedNumeric_1_Single_Action_1_GameObject_Action_1_Exception_OBJImportOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OBJExporterImporter(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_DuplicateTexture_Public_Static_Texture2D_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildRenderersForCombining_Public_Static_Il2CppReferenceArray_1_Renderer_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStaticLevelRenderer_Public_Static_MeshRenderer_String_Transform_Transform_Mesh_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkinnedLevelRenderer_Public_Static_SkinnedMeshRenderer_String_Transform_Transform_Mesh_Il2CppReferenceArray_1_Material_Transform_Il2CppReferenceArray_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectChildRenderersForCombining_Private_Static_Void_Transform_List_1_Renderer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParentAndResetTransform_Private_Static_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParentAndOffsetTransform_Public_Static_Void_Transform_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static UtilityServicesRuntime()
	{
		Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFewRuntime", "UtilityServicesRuntime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr);
		NativeMethodInfoPtr_DuplicateTexture_Public_Static_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677423);
		NativeMethodInfoPtr_GetChildRenderersForCombining_Public_Static_Il2CppReferenceArray_1_Renderer_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677424);
		NativeMethodInfoPtr_CreateStaticLevelRenderer_Public_Static_MeshRenderer_String_Transform_Transform_Mesh_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677425);
		NativeMethodInfoPtr_CreateSkinnedLevelRenderer_Public_Static_SkinnedMeshRenderer_String_Transform_Transform_Mesh_Il2CppReferenceArray_1_Material_Transform_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677426);
		NativeMethodInfoPtr_CollectChildRenderersForCombining_Private_Static_Void_Transform_List_1_Renderer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677427);
		NativeMethodInfoPtr_ParentAndResetTransform_Private_Static_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677428);
		NativeMethodInfoPtr_ParentAndOffsetTransform_Public_Static_Void_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677429);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr, 100677430);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380502, RefRangeEnd = 380503, XrefRangeStart = 380481, XrefRangeEnd = 380502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D DuplicateTexture(Texture2D source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DuplicateTexture_Public_Static_Texture2D_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380525, RefRangeEnd = 380526, XrefRangeStart = 380503, XrefRangeEnd = 380525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Renderer> GetChildRenderersForCombining(GameObject forObject, bool skipInactiveChildObjects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipInactiveChildObjects;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildRenderersForCombining_Public_Static_Il2CppReferenceArray_1_Renderer_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 380572, RefRangeEnd = 380574, XrefRangeStart = 380526, XrefRangeEnd = 380572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MeshRenderer CreateStaticLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Il2CppReferenceArray<Material> materials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStaticLevelRenderer_Public_Static_MeshRenderer_String_Transform_Transform_Mesh_Il2CppReferenceArray_1_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 380616, RefRangeEnd = 380618, XrefRangeStart = 380574, XrefRangeEnd = 380616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Il2CppReferenceArray<Material> materials, Transform rootBone, Il2CppReferenceArray<Transform> bones)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootBone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bones);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkinnedLevelRenderer_Public_Static_SkinnedMeshRenderer_String_Transform_Transform_Mesh_Il2CppReferenceArray_1_Material_Transform_Il2CppReferenceArray_1_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380659, RefRangeEnd = 380660, XrefRangeStart = 380618, XrefRangeEnd = 380659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CollectChildRenderersForCombining(Transform transform, List<Renderer> resultRenderers, bool skipInactiveChildObjects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultRenderers);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipInactiveChildObjects;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectChildRenderersForCombining_Private_Static_Void_Transform_List_1_Renderer_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 377088, RefRangeEnd = 377094, XrefRangeStart = 377088, XrefRangeEnd = 377094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentAndResetTransform(Transform transform, Transform parentTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParentAndResetTransform_Private_Static_Void_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 377108, RefRangeEnd = 377112, XrefRangeStart = 377108, XrefRangeEnd = 377112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParentAndOffsetTransform_Public_Static_Void_Transform_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UtilityServicesRuntime()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityServicesRuntime>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UtilityServicesRuntime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

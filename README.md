# BrokenJob_Nov26
Demonstration of a compilation error in Burst

Error dump when you build for Windows Standalone Player:
```
Burst.Compiler.IL.CompilerException: Error while processing function `System.Void Unity.Jobs.IJobExtensions/JobStruct`1<BrokenJob>::Execute(T&,System.IntPtr,System.IntPtr,Unity.Jobs.LowLevel.Unsafe.JobRanges&,System.Int32)` ---> Burst.Compiler.IL.CompilerException: Unexpected error while processing `IL_0008: callvirt System.Void BrokenJob::Execute() args(IL_0001)` ---> Burst.Compiler.IL.Syntax.BuilderException: Internal compiler error while processing function `System.Void BrokenJob::Execute()` ---> System.InvalidOperationException: Stack empty.
   at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
   at System.Collections.Generic.Stack`1.Peek()
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessInstruction(Instruction inst)
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessInstructions()
   --- End of inner exception stack trace ---
   at Burst.Compiler.IL.Syntax.ILBuilder.ThrowInternalError(Exception ex)
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessInstructions()
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessFunctionBody()
   at Burst.Compiler.IL.Syntax.ILBuilder.Visit(MethodBinding binding)
   at Burst.Compiler.IL.ILVisitor.PrepareFunctionInternal(MethodBinding methodBinding)
   at Burst.Compiler.IL.ILVisitor.Call(ILInstruction inst)
   at Burst.Compiler.IL.ILVisitor.CompileInternal(ILInstruction inst)
   at Burst.Compiler.IL.ILVisitor.Compile(ILInstruction inst)
   at Burst.Compiler.IL.ILVisitor.ProcessBlock(ILBlock block)
   --- End of inner exception stack trace ---
   at Burst.Compiler.IL.ILVisitor.ProcessBlock(ILBlock block)
   at Burst.Compiler.IL.ILVisitor.ProcessBlocks()
   at Burst.Compiler.IL.ILVisitor.ProcessFunctionBody(ILFunction function)
   at Burst.Compiler.IL.ILVisitor.VisitPendingFunctions()
   --- End of inner exception stack trace ---
   at Burst.Compiler.IL.ILVisitor.VisitPendingFunctions()
   at Burst.Compiler.IL.ILVisitor.VisitEntryPointFunction(MethodReferenceWithHash methodReference)
   at Burst.Compiler.IL.ILAnalyzer.Analyze(MethodReferenceWithHash method)
   at Burst.Compiler.IL.NativeCompiler.Initialize()
   at Burst.Compiler.IL.NativeCompiler.Compile()
   at Burst.Bcl.BclApp.CompileAndLink(List`1 methodsToCompile)
   at Burst.Bcl.Program.Main(String[] args)
   
   Failed running C:\Users\Eric\Desktop\BurstTest\Library\PackageCache\com.unity.burst@0.2.4-preview.38\.Runtime\bcl.exe @C:\Users\Eric\AppData\Local\Temp\tmp63cf0ce2.tmp

Failed running C:\Users\Eric\Desktop\BurstTest\Library\PackageCache\com.unity.burst@0.2.4-preview.38\.Runtime\bcl.exe @C:\Users\Eric\AppData\Local\Temp\tmp63cf0ce2.tmp

stdout:
An unexpected exception occurred: 
stderr:
Burst.Compiler.IL.CompilerException: Error while processing function `System.Void Unity.Jobs.IJobExtensions/JobStruct`1<BrokenJob>::Execute(T&,System.IntPtr,System.IntPtr,Unity.Jobs.LowLevel.Unsafe.JobRanges&,System.Int32)` ---> Burst.Compiler.IL.CompilerException: Unexpected error while processing `IL_0008: callvirt System.Void BrokenJob::Execute() args(IL_0001)` ---> Burst.Compiler.IL.Syntax.BuilderException: Internal compiler error while processing function `System.Void BrokenJob::Execute()` ---> System.InvalidOperationException: Stack empty.
   at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
   at System.Collections.Generic.Stack`1.Peek()
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessInstruction(Instruction inst)
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessInstructions()
   --- End of inner exception stack trace ---
   at Burst.Compiler.IL.Syntax.ILBuilder.ThrowInternalError(Exception ex)
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessInstructions()
   at Burst.Compiler.IL.Syntax.ILBuilder.ProcessFunctionBody()
   at Burst.Compiler.IL.Syntax.ILBuilder.Visit(MethodBinding binding)
   at Burst.Compiler.IL.ILVisitor.PrepareFunctionInternal(MethodBinding methodBinding)
   at Burst.Compiler.IL.ILVisitor.Call(ILInstruction inst)
   at Burst.Compiler.IL.ILVisitor.CompileInternal(ILInstruction inst)
   at Burst.Compiler.IL.ILVisitor.Compile(ILInstruction inst)
   at Burst.Compiler.IL.ILVisitor.ProcessBlock(ILBlock block)
   --- End of inner exception stack trace ---
   at Burst.Compiler.IL.ILVisitor.ProcessBlock(ILBlock block)
   at Burst.Compiler.IL.ILVisitor.ProcessBlocks()
   at Burst.Compiler.IL.ILVisitor.ProcessFunctionBody(ILFunction function)
   at Burst.Compiler.IL.ILVisitor.VisitPendingFunctions()
   --- End of inner exception stack trace ---
   at Burst.Compiler.IL.ILVisitor.VisitPendingFunctions()
   at Burst.Compiler.IL.ILVisitor.VisitEntryPointFunction(MethodReferenceWithHash methodReference)
   at Burst.Compiler.IL.ILAnalyzer.Analyze(MethodReferenceWithHash method)
   at Burst.Compiler.IL.NativeCompiler.Initialize()
   at Burst.Compiler.IL.NativeCompiler.Compile()
   at Burst.Bcl.BclApp.CompileAndLink(List`1 methodsToCompile)
   at Burst.Bcl.Program.Main(String[] args)

UnityEngine.Debug:LogError(Object)
UnityEditorInternal.Runner:RunProgram(Program, String, String, String, CompilerOutputParserBase) (at C:/buildslave/unity/build/Editor/Mono/BuildPipeline/BuildUtils.cs:128)
UnityEditorInternal.Runner:RunManagedProgram(String, String, String, CompilerOutputParserBase, Action`1) (at C:/buildslave/unity/build/Editor/Mono/BuildPipeline/BuildUtils.cs:73)
Unity.Burst.Editor.BurstAotCompiler:OnPostBuildPlayerScriptDLLs(BuildReport) (at Library/PackageCache/com.unity.burst@0.2.4-preview.38/Editor/BurstAotCompiler.cs:236)
UnityEngine.GUIUtility:ProcessEvent(Int32, IntPtr)

   
   ```

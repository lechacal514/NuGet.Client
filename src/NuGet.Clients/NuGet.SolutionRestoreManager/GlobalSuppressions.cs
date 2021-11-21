// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "VSTHRD110:Observe result of async calls", Justification = "https://github.com/NuGet/Home/issues/7674", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreEventPublisher.OnSolutionRestoreCompleted(NuGet.VisualStudio.SolutionRestoredEventArgs)")]
[assembly: SuppressMessage("Performance", "VSSDK004:Use BackgroundLoad flag in ProvideAutoLoad attribute for asynchronous auto load.", Justification = "https://github.com/NuGet/Home/issues/8796", Scope = "type", Target = "~T:NuGet.SolutionRestoreManager.RestoreManagerPackage")]
[assembly: SuppressMessage("Usage", "VSTHRD010:Invoke single-threaded types on Main thread", Justification = "https://github.com/microsoft/vs-threading/issues/577", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreJob.CheckPackagesConfigAsync~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Usage", "VSTHRD108:Assert thread affinity unconditionally", Justification = "Unclear what the consequences when the dispose is called from the analyzer", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreManagerPackage.Dispose(System.Boolean)")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'OnSolutionRestoreCompleted' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreEventPublisher.OnSolutionRestoreCompleted(NuGet.VisualStudio.SolutionRestoredEventArgs)")]
[assembly: SuppressMessage("Build", "CA1801:Parameter token of method StartAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreOperationLogger.StatusBarProgress.StartAsync(Microsoft.VisualStudio.Shell.IAsyncServiceProvider,Microsoft.VisualStudio.Threading.JoinableTaskFactory,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.SolutionRestoreManager.RestoreOperationProgressUI}")]
[assembly: SuppressMessage("Build", "CA1801:Parameter token of method StartAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreOperationLogger.WaitDialogProgress.StartAsync(Microsoft.VisualStudio.Shell.IAsyncServiceProvider,Microsoft.VisualStudio.Threading.JoinableTaskFactory,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.SolutionRestoreManager.RestoreOperationProgressUI}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'ExecuteAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "Avoid crashing devenv.exe process", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreJob.ExecuteAsync(NuGet.VisualStudio.SolutionRestoreRequest,NuGet.PackageManagement.VisualStudio.SolutionRestoreJobContext,NuGet.SolutionRestoreManager.RestoreOperationLogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA1801:Parameter jtf of method ContinuationAction is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreWorker.BackgroundRestoreOperation.ContinuationAction(System.Threading.Tasks.Task{System.Boolean},Microsoft.VisualStudio.Threading.JoinableTaskFactory)")]
[assembly: SuppressMessage("Build", "CA1303:Method 'Task SolutionRestoreWorker.PromoteTaskToActiveAsync(BackgroundRestoreOperation restoreOperation, CancellationToken token)' passes a literal string as parameter 'message' of a call to 'InvalidOperationException.InvalidOperationException(string message)'. Retrieve the following string(s) from a resource table instead: \"Failed promoting pending task.\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreWorker.PromoteTaskToActiveAsync(NuGet.SolutionRestoreManager.SolutionRestoreWorker.BackgroundRestoreOperation,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'ScheduleRestoreAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreWorker.ScheduleRestoreAsync(NuGet.VisualStudio.SolutionRestoreRequest,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'StartBackgroundJobRunnerAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreWorker.StartBackgroundJobRunnerAsync(System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA1303:Method 'Task<bool> VsSolutionRestoreService.NominateProjectAsync(string projectUniqueName, IVsProjectRestoreInfo projectRestoreInfo, IVsProjectRestoreInfo2 projectRestoreInfo2, CancellationToken token)' passes a literal string as parameter 'message' of a call to 'InvalidOperationException.InvalidOperationException(string message)'. Retrieve the following string(s) from a resource table instead: \"TargetFrameworks cannot be null.\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.VsSolutionRestoreService.NominateProjectAsync(System.String,NuGet.SolutionRestoreManager.IVsProjectRestoreInfo,NuGet.SolutionRestoreManager.IVsProjectRestoreInfo2,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'NominateProjectAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.VsSolutionRestoreService.NominateProjectAsync(System.String,NuGet.SolutionRestoreManager.IVsProjectRestoreInfo,NuGet.SolutionRestoreManager.IVsProjectRestoreInfo2,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'VsSolutionRestoreService.NominateProjectAsync(string, IVsProjectRestoreInfo, IVsProjectRestoreInfo2, CancellationToken)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.VsSolutionRestoreService.NominateProjectAsync(System.String,NuGet.SolutionRestoreManager.IVsProjectRestoreInfo,NuGet.SolutionRestoreManager.IVsProjectRestoreInfo2,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Boolean}")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreOperationLogger.StatusBarProgress.StartAsync(Microsoft.VisualStudio.Shell.IAsyncServiceProvider,Microsoft.VisualStudio.Threading.JoinableTaskFactory,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.SolutionRestoreManager.RestoreOperationProgressUI}")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.RestoreOperationLogger.WaitDialogProgress.StartAsync(Microsoft.VisualStudio.Shell.IAsyncServiceProvider,Microsoft.VisualStudio.Threading.JoinableTaskFactory,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.SolutionRestoreManager.RestoreOperationProgressUI}")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.SolutionRestoreManager.SolutionRestoreWorker.BackgroundRestoreOperation.ContinuationAction(System.Threading.Tasks.Task{System.Boolean},Microsoft.VisualStudio.Threading.JoinableTaskFactory)")]

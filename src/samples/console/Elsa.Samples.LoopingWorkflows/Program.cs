﻿using Elsa.Extensions;
using Elsa.Samples.LoopingWorkflows.Workflows;
using Elsa.Workflows.Core.Services;
using Microsoft.Extensions.DependencyInjection;

// Setup service container.
var services = new ServiceCollection();

// Add Elsa services.
services.AddElsa();

// Build service container.
var serviceProvider = services.BuildServiceProvider();

// Resolve a workflow runner to run the workflow.
var workflowRunner = serviceProvider.GetRequiredService<IWorkflowRunner>();

// Run the ForWorkflow.
await workflowRunner.RunAsync(ForWorkflow.Create());
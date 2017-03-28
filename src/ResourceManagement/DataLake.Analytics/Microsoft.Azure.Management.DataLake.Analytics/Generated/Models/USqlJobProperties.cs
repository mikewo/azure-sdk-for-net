// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// U-SQL job properties used when submitting and retrieving U-SQL jobs.
    /// </summary>
    [Newtonsoft.Json.JsonObject("USql")]
    public partial class USqlJobProperties : JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the USqlJobProperties class.
        /// </summary>
        public USqlJobProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the USqlJobProperties class.
        /// </summary>
        /// <param name="script">the script to run</param>
        /// <param name="runtimeVersion">the runtime version of the Data Lake
        /// Analytics engine to use for the specific type of job being
        /// run.</param>
        /// <param name="resources">the list of resources that are required by
        /// the job</param>
        /// <param name="statistics">the job specific statistics.</param>
        /// <param name="debugData">the job specific debug data
        /// locations.</param>
        /// <param name="diagnostics">the diagnostics for the job.</param>
        /// <param name="algebraFilePath">the algebra file path after the job
        /// has completed</param>
        /// <param name="totalCompilationTime">the total time this job spent
        /// compiling. This value should not be set by the user and will be
        /// ignored if it is.</param>
        /// <param name="totalPauseTime">the total time this job spent paused.
        /// This value should not be set by the user and will be ignored if it
        /// is.</param>
        /// <param name="totalQueuedTime">the total time this job spent queued.
        /// This value should not be set by the user and will be ignored if it
        /// is.</param>
        /// <param name="totalRunningTime">the total time this job spent
        /// executing. This value should not be set by the user and will be
        /// ignored if it is.</param>
        /// <param name="rootProcessNodeId">the ID used to identify the job
        /// manager coordinating job execution. This value should not be set by
        /// the user and will be ignored if it is.</param>
        /// <param name="yarnApplicationId">the ID used to identify the yarn
        /// application executing the job. This value should not be set by the
        /// user and will be ignored if it is.</param>
        /// <param name="yarnApplicationTimeStamp">the timestamp (in ticks) for
        /// the yarn application executing the job. This value should not be
        /// set by the user and will be ignored if it is.</param>
        /// <param name="compileMode">Optionally enforces a specific
        /// compilation mode for the job during execution. If this is not
        /// specified during submission, the server will determine the optimal
        /// compilation mode. Possible values include: 'Semantic', 'Full',
        /// 'SingleBox'</param>
        public USqlJobProperties(string script, string runtimeVersion = default(string), IList<JobResource> resources = default(IList<JobResource>), JobStatistics statistics = default(JobStatistics), JobDataPath debugData = default(JobDataPath), IList<Diagnostics> diagnostics = default(IList<Diagnostics>), string algebraFilePath = default(string), System.TimeSpan? totalCompilationTime = default(System.TimeSpan?), System.TimeSpan? totalPauseTime = default(System.TimeSpan?), System.TimeSpan? totalQueuedTime = default(System.TimeSpan?), System.TimeSpan? totalRunningTime = default(System.TimeSpan?), string rootProcessNodeId = default(string), string yarnApplicationId = default(string), long? yarnApplicationTimeStamp = default(long?), CompileMode? compileMode = default(CompileMode?))
            : base(script, runtimeVersion)
        {
            Resources = resources;
            Statistics = statistics;
            DebugData = debugData;
            Diagnostics = diagnostics;
            AlgebraFilePath = algebraFilePath;
            TotalCompilationTime = totalCompilationTime;
            TotalPauseTime = totalPauseTime;
            TotalQueuedTime = totalQueuedTime;
            TotalRunningTime = totalRunningTime;
            RootProcessNodeId = rootProcessNodeId;
            YarnApplicationId = yarnApplicationId;
            YarnApplicationTimeStamp = yarnApplicationTimeStamp;
            CompileMode = compileMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of resources that are required by the job
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<JobResource> Resources { get; set; }

        /// <summary>
        /// Gets or sets the job specific statistics.
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public JobStatistics Statistics { get; set; }

        /// <summary>
        /// Gets or sets the job specific debug data locations.
        /// </summary>
        [JsonProperty(PropertyName = "debugData")]
        public JobDataPath DebugData { get; set; }

        /// <summary>
        /// Gets or sets the diagnostics for the job.
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public IList<Diagnostics> Diagnostics { get; set; }

        /// <summary>
        /// Gets the algebra file path after the job has completed
        /// </summary>
        [JsonProperty(PropertyName = "algebraFilePath")]
        public string AlgebraFilePath { get; private set; }

        /// <summary>
        /// Gets the total time this job spent compiling. This value should not
        /// be set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalCompilationTime")]
        public System.TimeSpan? TotalCompilationTime { get; private set; }

        /// <summary>
        /// Gets the total time this job spent paused. This value should not be
        /// set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalPauseTime")]
        public System.TimeSpan? TotalPauseTime { get; private set; }

        /// <summary>
        /// Gets the total time this job spent queued. This value should not be
        /// set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalQueuedTime")]
        public System.TimeSpan? TotalQueuedTime { get; private set; }

        /// <summary>
        /// Gets the total time this job spent executing. This value should not
        /// be set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalRunningTime")]
        public System.TimeSpan? TotalRunningTime { get; private set; }

        /// <summary>
        /// Gets the ID used to identify the job manager coordinating job
        /// execution. This value should not be set by the user and will be
        /// ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "rootProcessNodeId")]
        public string RootProcessNodeId { get; private set; }

        /// <summary>
        /// Gets the ID used to identify the yarn application executing the
        /// job. This value should not be set by the user and will be ignored
        /// if it is.
        /// </summary>
        [JsonProperty(PropertyName = "yarnApplicationId")]
        public string YarnApplicationId { get; private set; }

        /// <summary>
        /// Gets the timestamp (in ticks) for the yarn application executing
        /// the job. This value should not be set by the user and will be
        /// ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "yarnApplicationTimeStamp")]
        public long? YarnApplicationTimeStamp { get; private set; }

        /// <summary>
        /// Gets or sets optionally enforces a specific compilation mode for
        /// the job during execution. If this is not specified during
        /// submission, the server will determine the optimal compilation mode.
        /// Possible values include: 'Semantic', 'Full', 'SingleBox'
        /// </summary>
        [JsonProperty(PropertyName = "compileMode")]
        public CompileMode? CompileMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

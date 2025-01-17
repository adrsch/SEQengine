// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace Stride.Physics
{
    public enum CollisionFilterGroups //needed for the editor as this is not tagged as flag...
    {
        DefaultFilter = 0x1,

        StaticFilter = 0x2,

        KinematicFilter = 0x4,

        DebrisFilter = 0x8,

        SensorTrigger = 0x10,

        CharacterFilter = 0x20,

        CustomFilter1 = 0x40,

        CustomFilter2 = 0x80,

        CustomFilter3 = 0x100,

        CustomFilter4 = 0x200,

        CustomFilter5 = 0x400,

        CustomFilter6 = 0x800,

        CustomFilter7 = 0x1000,

        CustomFilter8 = 0x2000,

        CustomFilter9 = 0x4000,

        CustomFilter10 = 0x8000,

        InteractiveFilter = 1 << 17,
        AIFilter = 1 << 18,
        ProjectileFilter = 1 << 19,

        AllFilter = 0xFFFF,
    }

    [Flags]
    public enum CollisionFilterGroupFlags
    {
        DefaultFilter = 1,

        StaticFilter = 1 << 1,

        KinematicFilter = 1 << 3,

        DebrisFilter = 1 << 4,

        SensorTrigger = 1 << 5,

        CharacterFilter = 1 << 6,

        CustomFilter1 = 1 << 7,

        CustomFilter2 = 1 << 8,

        CustomFilter3 = 1 << 9,

        CustomFilter4 = 1 << 10,

        CustomFilter5 = 1 << 11,

        CustomFilter6 = 1 << 12,

        CustomFilter7 = 1 << 13,

        CustomFilter8 = 1 << 14,

        CustomFilter9 = 1 << 15,

        CustomFilter10 = 1 << 16,

        InteractiveFilter = 1 << 17,
        AIFilter = 1 << 18,
        ProjectileFilter = 1 << 19,

        AllFilter = 0xFFFF,
    }

    /// <summary>
    /// Flags that control how ray tests are performed
    /// </summary>
    [Flags]
    public enum EFlags : uint
    {
        None = 0,
        /// <summary>
        /// Do not return a hit when a ray traverses a back-facing triangle
        /// </summary>
        FilterBackfaces = 1 << 0,
        /// <summary>
        /// Prevents returned face normal getting flipped when a ray hits a back-facing triangle
        /// </summary>
        KeepUnflippedNormal = 1 << 1,
        /// <summary>
        /// Uses an approximate but faster ray versus convex intersection algorithm
        /// SubSimplexConvexCastRaytest is the default, even if kF_None is set.
        /// </summary>
        UseSubSimplexConvexCastRaytest = 1 << 2,
        UseGjkConvexCastRaytest = 1 << 3,
        /// <summary>
        /// Don't use the heightfield raycast accelerator. See https://github.com/bulletphysics/bullet3/pull/2062
        /// </summary>
        DisableHeightfieldAccelerator  = 1 << 4
    }
}

using Unity.Burst;

namespace Fuji.JellyPhysics
{
    using Unity.Collections;
    using Unity.Jobs;
    using Unity.Mathematics;
    
    [BurstCompile]
    public struct BrokenJob : IJob
    {
        public NativeArray<float3> GrabConstraints;

        [ReadOnly] public float3x3 LeftHandPosition, RightHandPosition;

        public void Execute()
        {
            for (int grabIndex = 0; grabIndex < GrabConstraints.Length; grabIndex++)
            {
                bool isLeft = grabIndex == 0 || grabIndex == 2;
                var pos = isLeft ? LeftHandPosition.c0 : RightHandPosition.c0;
                int grabStatKey = isLeft ? 1 : 2;
            }
        }
    }
}
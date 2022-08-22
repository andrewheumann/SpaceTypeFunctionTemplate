using Elements;
using Elements.Geometry;
using LayoutFunctionCommon;
using System.Collections.Generic;

namespace SpaceTypeFunctionTemplate
{
    public static class SpaceTypeFunctionTemplate
    {
        /// <summary>
        /// The SpaceTypeFunctionTemplate function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A SpaceTypeFunctionTemplateOutputs instance containing computed results and the model with any new elements.</returns>
        public static SpaceTypeFunctionTemplateOutputs Execute(Dictionary<string, Model> inputModels, SpaceTypeFunctionTemplateInputs input)
        {
            var output = new SpaceTypeFunctionTemplateOutputs();
            LayoutStrategies.StandardLayoutOnAllLevels<LevelElements, LevelVolume, SpaceBoundary>(
                "SPACE_TYPE", // the room type to apply to
                inputModels,
                input.Overrides,
                output.Model,
                SHOULD_CREATE_WALLS, // true if this type should create walls
                "./config.json", // config json path
                "./catalog.json"); // catalog json path
            return output;
        }
    }
}
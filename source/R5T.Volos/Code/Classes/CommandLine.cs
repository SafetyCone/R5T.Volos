using System;

using R5T.Heraklion;
using R5T.Heraklion.Default;
using R5T.Piraeus.StringBuilder;


namespace R5T.Volos
{
    public static class CommandLine
    {
        public static ICommandBuilderContext<TContext> New<TContext>()
        {
            var commandBuilder = new StringBuilderBasedCommandBuilder();

            var commandBuilderContext = new CommandBuilderContext<TContext>(commandBuilder);
            return commandBuilderContext;
        }
    }
}

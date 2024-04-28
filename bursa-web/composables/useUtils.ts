export const useUtils = () => {

    const removeTrailingSpaces = (input: string): string => {
        return input.replace(/\s+$/, '');
    };

    return {
        removeTrailingSpaces
    };
};
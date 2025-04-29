export function cssStringToObject(styleString: string): React.CSSProperties {
    return styleString
      .split(';')
      .filter(rule => rule.trim() !== '')
      .reduce((styleObj, rule) => {
        const [property, value] = rule.split(':');
        if (!property || !value) return styleObj;
  
        const camelCaseProp = property
          .trim()
          .replace(/-([a-z])/g, (_, char) => char.toUpperCase());
  
        styleObj[camelCaseProp as keyof React.CSSProperties] = value.trim() as any
        return styleObj;
    }, {} as React.CSSProperties);
}
import React from 'react';
import {
  Modal as ModalReact,
  Text,
  View,
  StyleSheet,
  TouchableOpacity,
  Dimensions,
} from 'react-native';

import theme from '../theme/default';

const {width, height} = Dimensions.get('window');

export default Modal = () => {
  return (
    <ModalReact
      animationType="slide"
      transparent={true}
      visible={false}
      style={styles.teste}>
      <View style={styles.modal}>
        <View style={styles.container}>
          <View style={styles.header}>
            <Text style={styles.headerText}>New Task</Text>
          </View>
          <View style={styles.body}>
            <Text>Input</Text>
          </View>
          <View style={styles.footer}>
            <TouchableOpacity style={[styles.button, styles.buttonSecondary]}>
              <Text style={[styles.buttonText, styles.buttonSecondaryText]}>
                Cancel
              </Text>
            </TouchableOpacity>
            <TouchableOpacity style={[styles.button, styles.buttonPrimary]}>
              <Text style={[styles.buttonText, styles.buttonPrimaryText]}>
                Confirm
              </Text>
            </TouchableOpacity>
          </View>
        </View>
      </View>
    </ModalReact>
  );
};

const styles = StyleSheet.create({
  modal: {
    flex: 1,
    paddingHorizontal: 16,
    backgroundColor: 'rgba(52, 52, 52, 0.55)',
  },
  container: {
    backgroundColor: 'white',
    justifyContent: 'space-between',
    // height: height * 0.8,
  },
  header: {
    padding: 16,
    borderColor: '#c4c4c4',
    borderBottomWidth: 1,
  },
  headerText: {
    fontSize: 20,
    fontWeight: 'bold',
  },
  body: {
    padding: 16,
  },
  footer: {
    padding: 16,
    flexDirection: 'row',
    justifyContent: 'flex-end',
    borderColor: '#c4c4c4',
    borderTopWidth: 1,
  },
  button: {
    justifyContent: 'center',
    alignItems: 'center',
    marginLeft: 16,
    borderRadius: 2,
    height: 36,
    width: 94,
  },
  buttonText: {
    fontSize: 14,
    fontWeight: '500',
  },
  buttonPrimary: {
    backgroundColor: theme.primary,
  },
  buttonPrimaryText: {
    color: 'white',
  },
  buttonSecondary: {
    backgroundColor: theme.secondary,
  },
  buttonSecondaryText: {
    color: '#5B5B5B',
  },
});
